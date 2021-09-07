using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing.Visitors
{
    public class LambdaVisitor : Visitor
    {
        private readonly LambdaExpression _Node;
        public LambdaVisitor(LambdaExpression node) : base(node)
        {
            _Node = node;
        }

        public override void Visit(Query query, Dictionary<string, object> visitorInfo)
        {
            //string method = visitorInfo.ContainsKey("method") ? visitorInfo["method"].ToString() : String.Empty;
            Condition condition = null;

            if (_Node.Body is BinaryExpression)
                condition = CreateCondition((BinaryExpression)_Node.Body);

            if (_Node.Body is MethodCallExpression)
                condition = CreateCondition((MethodCallExpression)_Node.Body);

            if (condition != null)
                query.Conditions.Add(condition);
        }

        private Condition CreateCondition(MethodCallExpression exp)
        {
            var methodName = exp.Method.Name;
            var allMethods = exp.Method.DeclaringType.GetMethods();
            var method = allMethods.Where(m => m.Name.Equals(methodName)).FirstOrDefault();

            if (methodName.Equals("Equals") && method.DeclaringType.Name.Equals("String"))            
                return CreateCondition(BinaryExpression.Equal(exp.Object, exp.Arguments.FirstOrDefault()));
            
            throw new NotImplementedException($"this call method is not suported [{exp.NodeType}]");
        }

        private Condition CreateCondition(BinaryExpression exp)
        {
            Condition condition = null;
            var op = Condition.GetOperator(exp.NodeType);

            switch (exp.NodeType)
            {
                case ExpressionType.Equal:
                case ExpressionType.GreaterThan:
                    {
                        var left = (MemberExpression)exp.Left;
                        var right = (ConstantExpression)exp.Right;
                        condition = new Condition()
                        {
                            LeftOperand = left.Member.Name,
                            Operator = op,
                            RightOperand = right.Value
                        };
                        break;
                    }                    
                case ExpressionType.OrElse:
                case ExpressionType.AndAlso:
                    {
                        Condition left = CreateCondition((BinaryExpression)exp.Left);
                        Condition right = CreateCondition((BinaryExpression)exp.Right);
                        condition = new Condition()
                        {
                            LeftOperand = left,
                            Operator = op,
                            RightOperand = right
                        };
                        break;
                    }
                default:
                    throw new NotImplementedException($"unknown expression type [{exp.NodeType}]");
            }

            return condition;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            var body = (BinaryExpression)_Node.Body;
            Condition condition = CreateCondition((BinaryExpression)_Node.Body);

            if (condition != null)
                query.Conditions.Add(condition);
        }

        private Condition CreateCondition(BinaryExpression exp)
        {
            Condition condition = null;
            var op = Condition.GetOperator(exp.NodeType);

            switch (exp.NodeType)
            {
                case ExpressionType.Equal:
                case ExpressionType.GreaterThan:                    
                    var left = (MemberExpression)exp.Left;
                    var right = (ConstantExpression)exp.Right;
                    condition = new Condition()
                    {
                        LeftOperand = left.Member.Name,
                        Operator = op,
                        RightOperand = right.Value
                    };
                    break;
                case ExpressionType.OrElse:
                    Condition leftCond = CreateCondition((BinaryExpression)exp.Left);
                    Condition rightCond = CreateCondition((BinaryExpression)exp.Right);
                    condition = new Condition()
                    {
                        LeftOperand = leftCond,
                        Operator = op,
                        RightOperand = rightCond
                    };
                    break;
                default:
                    throw new NotImplementedException($"unknown expression type [{exp.NodeType}]");
            }

            return condition;
        }
    }
}

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
            string method = visitorInfo.ContainsKey("method") ? visitorInfo["method"].ToString() : String.Empty;
            var body = (BinaryExpression)_Node.Body;

            switch (body.NodeType)
            {
                case ExpressionType.Equal:                    
                    query.Conditions.Add(CreateSimpleCondition(body));
                    break;
                case ExpressionType.OrElse:
                default:
                    break;
            }
        }

        private Condition CreateSimpleCondition(BinaryExpression exp)
        {
            var op = Condition.GetOperator(exp.NodeType);
            var left = (MemberExpression)exp.Left;
            var right = (ConstantExpression)exp.Right;
            return new Condition() 
            { 
                LeftOperand = left.Member.Name, 
                Operator = op, 
                RightOperand = right.Value 
            };
        }
    }
}

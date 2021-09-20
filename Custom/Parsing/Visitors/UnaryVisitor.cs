using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing.Visitors
{
    public class UnaryVisitor : Visitor
    {
        private readonly UnaryExpression _Node;
        public UnaryVisitor(UnaryExpression node) : base(node)
        {
            _Node = node;
        }

        public override void Visit(Query query, string methodName)
        {
            //2
            //prefix = prefix + "-Unary-";
            var bodyVisitor = Visitor.CreateFromExpression(_Node.Operand);
            bodyVisitor.Visit(query, methodName);
        }
    }
}

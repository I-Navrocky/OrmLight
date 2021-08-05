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

        public override void Visit(string prefix)
        {
            foreach(var argumentExpression in _Node.Parameters)
            {
                var argumentVisitor = Visitor.CreateFromExpression(argumentExpression);
                prefix = prefix + "-Lambda-";
                argumentVisitor.Visit(prefix);
            }
        }
    }
}

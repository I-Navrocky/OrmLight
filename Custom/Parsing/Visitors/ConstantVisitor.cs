using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing.Visitors
{
    public class ConstantVisitor : Visitor
    {
        private readonly ConstantExpression _Node;
        public ConstantVisitor(ConstantExpression node) : base(node)
        {
            _Node = node;
        }

        public override void Visit(string prefix)
        {
            var entityType = _Node.Value.GetType().GenericTypeArguments[0];
            prefix = prefix + "-Constant-";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing.Visitors
{
    public class ParameterVisitor : Visitor
    {
        private readonly ParameterExpression _Node;
        public ParameterVisitor(ParameterExpression node) : base(node)
        {
            _Node = node;
        }

        public override void Visit(Query query)
        {
            //3
        }
    }
}

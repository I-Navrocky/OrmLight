using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing.Visitors
{
    public class MethodCallVisitor : Visitor
    {
        private readonly MethodCallExpression _Node;

        public MethodCallVisitor(MethodCallExpression node) : base(node)
        {
            _Node = node;
        }

        public override void Visit(Query query, string methodName)
        {
            methodName = _Node.Method?.Name;

            foreach (var arg in _Node.Arguments)
            {               
                var argVisitor = Visitor.CreateFromExpression(arg);
                argVisitor.Visit(query, methodName);
            }
        }
    }
}

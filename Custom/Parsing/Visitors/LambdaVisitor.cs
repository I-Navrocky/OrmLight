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

        public override void Visit(Query query)
        {
            var body = (BinaryExpression)_Node.Body;
            var left = body.Left;

            switch (body.NodeType)
            {
                
            }

            //foreach(var argumentExpression in _Node.Parameters)
            //{
            //    var argumentVisitor = Visitor.CreateFromExpression(argumentExpression);
            //    argumentVisitor.Visit(query);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing.Visitors
{
    public abstract class Visitor
    {
        private readonly Expression _Node;
        public ExpressionType NodeType => _Node.NodeType;

        public Visitor(Expression node)
        {
            _Node = node;
        }

        public abstract void Visit(string prefix);

        public static Visitor CreateFromExpression(Expression node)
        {
            switch (node.NodeType)
            {
                case ExpressionType.Call:
                    return new MethodCallVisitor((MethodCallExpression)node);
                case ExpressionType.Constant:
                    return new ConstantVisitor((ConstantExpression)node);
                case ExpressionType.Quote:
                    return new UnaryVisitor((UnaryExpression)node);
                case ExpressionType.Lambda:
                    return new LambdaVisitor((LambdaExpression)node);
                case ExpressionType.Parameter:
                    return new ParameterVisitor((ParameterExpression)node);
                default:
                    Console.Error.WriteLine($"Node not processed yet: {node.NodeType}");
                    return default(Visitor);
            }
        }

    }
}

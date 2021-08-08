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

        public override void Visit(Query query, Dictionary<string, object> visitorInfo)
        {
            Type entityType = null;

            if (query.EntityType == null)
            {
                entityType = _Node.Value.GetType().GenericTypeArguments?.FirstOrDefault();

                if (entityType == null)
                    throw new ApplicationException("entity type");

                query.EntityType = entityType;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OrmLight.Custom.Parsing.Visitors;

namespace OrmLight.Custom.Parsing
{
    public static class ExpressionParser
    {        
        public static bool TryParse(Expression expression, DalOperation operation, out Query query)
        {
            query = new Query() { Operation = operation };
            var visitor = Visitor.CreateFromExpression(expression);
            visitor.Visit(query, null);
          
            return true;
        }

        private static bool ParseArgument(Expression expression, Query query)
        {
            return true;
        }
    }
}

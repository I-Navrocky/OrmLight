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
        public static bool TryParse(Expression expression, out Query query)
        {
            query = new Query();
            var visitor = Visitor.CreateFromExpression(expression);
            visitor.Visit(query);
           

            return true;
        }

        private static bool ParseArgument(Expression expression, Query query)
        {
            return true;
        }
    }
}

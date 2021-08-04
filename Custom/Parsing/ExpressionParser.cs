using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing
{
    public static class ExpressionParser
    {
        public static bool TryParse(Expression expression, out Query query)
        {
            query = new Query();
            bool result = false;

            //Visitor visitor = new Visitor();
            //visitor.Visit(expression);

           

            return true;
        }

        private static bool ParseArgument(Expression expression, Query query)
        {
            return true;
        }
    }
}

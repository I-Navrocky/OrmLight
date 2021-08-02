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
        public static bool Parse(Expression exp, out Query query)
        {
            query = new Query();
            return true;
        }
    }
}

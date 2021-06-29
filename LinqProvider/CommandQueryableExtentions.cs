using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Linq
{
    public static class CommandQueryableExtentions
    {
        public static ICommandQueryable Where<TSource>(this ICommandQueryable command, Expression<Func<TSource, bool>> exp)
        {

            return command;
        }
    }
}

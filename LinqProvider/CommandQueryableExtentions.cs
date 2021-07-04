using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Linq
{
    public static class CommandQueryableExtentions
    {
        public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            //var exp = Expression.AndAlso(source.Expression, predicate);
            //var queryableType = typeof(Queryable);
            var where = new Func<IQueryable<int>, Expression<Func<int, bool>>, IQueryable<int>>(Queryable.Where).Method;
            var whereForMyType = where.GetGenericMethodDefinition().MakeGenericMethod(typeof(TSource));

            return null;


            //return source.Provider.CreateQuery<TSource>(source.Expression.);

            //return source.Provider.CreateQuery<TSource>(
            //    Expression.Call(
            //        typeof(Queryable),
            //        "Where",
            //        new Type[] { source.ElementType, predicate.Body.Type },
            //        new[] { source.Expression, Expression.Quote(predicate) }));


            ////TODO: проверка параметров
            //dynamic operation = predicate.Body;
            //var left = operation.Left;
            //var right = operation.Right;
            //ICondition condition = null;
            //switch (predicate.Body.NodeType)
            //{
            //    case ExpressionType.Equal:
            //        condition = Condition.Equal;
            //        condition.LeftOperand = left.Member.Name;
            //        condition.RightOperand = right.Value;
            //        break;
            //    default:
            //        break;
            //};

            //if (condition == null)
            //    throw new NotImplementedException($"operation type [${predicate.Body.NodeType}] not supported");

            ////var newConditions = new List<ICondition>(command.Conditions).Concat(condition);

            //return new OrmLightCommand<TSource>(command.Provider)
            //{
            //    Conditions = command.Conditions.Append(condition).ToList()
            //};
        }
    }
}

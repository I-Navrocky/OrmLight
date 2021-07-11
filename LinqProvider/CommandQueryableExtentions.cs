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
        public static IQuery<TSource> Where<TSource>(this IQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            //TODO: проверка параметров
            dynamic operation = predicate.Body;
            var left = operation.Left;
            var right = operation.Right;
            ICondition condition = null;
            switch (predicate.Body.NodeType)
            {
                case ExpressionType.Equal:
                    condition = Condition.Equal;
                    condition.LeftOperand = left.Member.Name;
                    condition.RightOperand = right.Value;
                    break;
                default:
                    break;
            };

            if (condition == null)
                throw new NotImplementedException($"operation type [${predicate.Body.NodeType}] not supported");

            return new Query<TSource>(source.Provider, predicate)
            {
                Conditions = source.Conditions.Append(condition).ToList()
            };
        }
    }
}

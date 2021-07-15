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
            var conditions = new List<ICondition>();
            switch (predicate.Body.NodeType)
            {
                case ExpressionType.Equal:
                    var cond = Condition.Equal;
                    cond.LeftOperand = left.Member.Name;
                    cond.RightOperand = right.right.Value;
                    conditions.Add(cond);
                    break;
                case ExpressionType.OrElse:
                    //conditions = 
                    //    conditions.Concat(ParseExpression(operation.Left))
                    //    .Concat(ParseExpression(operation.Right));
                    //break;
                default:
                    break;
            };

            if (conditions.Count == 0)
                throw new NotImplementedException($"operation type [${predicate.Body.NodeType}] not supported");

            return new Query<TSource>(source.Provider, predicate)
            {
                Conditions = source.Conditions.Concat(conditions).ToList()
            };
        }

        //private static List<Condition> ParseExpression(Expression exp)
        //{
        //    var result = new List<Condition>();

        //    dynamic operation = exp.Body;
        //    var left = operation.Left;
        //    var right = operation.Right;
        //    ICondition condition = null;
        //    switch (exp.Body.NodeType)
        //    {
        //        case ExpressionType.Equal:
        //            condition = Condition.Equal;
        //            condition.LeftOperand = left.Member.Name;
        //            condition.RightOperand = right.Value;
        //            break;
        //        default:
        //            break;
        //    };

        //    return result;
        //}
    }
}

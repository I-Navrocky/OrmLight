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
        public static ICommandQueryable Where<TSource>(this ICommandQueryable command, Expression<Func<TSource, bool>> predicate)
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

            //var newConditions = new List<ICondition>(command.Conditions).Concat(condition);
       
            return new OrmLightCommand(command.EntityType, command.Provider)
            {
                Conditions = command.Conditions.Append(condition).ToList()
            };
        }
    }
}

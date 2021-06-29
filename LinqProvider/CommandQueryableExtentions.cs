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
            var newCommand = command.Provider.CreateCommand(command);
            Condition condition = null;
            var binExp = predicate.Body as BinaryExpression;
            var left = binExp.Left.ToString();
            foreach (var param in predicate.Parameters)
                left = left.Replace($"{param}.", String.Empty);

            switch (predicate.Body.NodeType)
            {
                case ExpressionType.Equal:
                    condition = Condition.Equal;                    
                    break;
                default:
                    break;
            };
            
            condition.LeftOperand = left;
            condition.RightOperand = binExp.Right;
            newCommand.Conditions.ToList().Add(condition);

            return newCommand;
        }
    }
}

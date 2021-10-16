using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace OrmLight
{
    public class Condition : ICondition
    {
        public object LeftOperand { get; set; }
        public ConditionOperator Operator { get; set; }
        public object RightOperand { get; set; }
        public static Condition Equal => new Condition() { Operator = ConditionOperator.Equal };


        public static ConditionOperator GetOperator(ExpressionType type)
        {
            switch (type)
            {
                case ExpressionType.Equal:
                    return ConditionOperator.Equal;
                case ExpressionType.GreaterThan:
                    return ConditionOperator.Greater;
                case ExpressionType.LessThan:
                    return ConditionOperator.Less;
                case ExpressionType.OrElse:
                    return ConditionOperator.Or;
                case ExpressionType.AndAlso:
                    return ConditionOperator.And;
                //TODO: etc 
                default:
                    throw new ApplicationException("unknown operator");
            }
        }

    }
}

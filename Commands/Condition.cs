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
        public Operator Operator { get; set; }
        public object RightOperand { get; set; }
        public static Condition Equal => new Condition() { Operator = Operator.Equal };


        public static Operator GetOperator(ExpressionType type)
        {
            switch (type)
            {
                case ExpressionType.Equal:
                    return Operator.Equal;
                case ExpressionType.GreaterThan:
                    return Operator.Greater;
                case ExpressionType.LessThan:
                    return Operator.Less;
                case ExpressionType.OrElse:
                    return Operator.Or;
                case ExpressionType.AndAlso:
                    return Operator.And;
                //TODO: etc 
                default:
                    throw new ApplicationException("unknown operator");
            }
        }

    }
}

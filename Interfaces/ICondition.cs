using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public interface ICondition
    {
        object LeftOperand { get; set; }
        ConditionOperator Operator { get; set; }
        object RightOperand { get; set; }
    }
}

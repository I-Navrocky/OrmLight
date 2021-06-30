using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public interface ICondition
    {
        string LeftOperand { get; set; }
        Operator Operator { get; set; }
        object RightOperand { get; set; }
    }
}

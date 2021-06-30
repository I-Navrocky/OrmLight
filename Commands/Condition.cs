using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public class Condition : ICondition
    {
        public string LeftOperand { get; set; }
        public Operator Operator { get; set; }
        public object RightOperand { get; set; }
        public static Condition Equal => new Condition() { Operator = Operator.Equal };

    }
}

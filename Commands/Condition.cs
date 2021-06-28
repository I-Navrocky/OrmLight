using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public class Condition : ICondition
    {
        public string LeftOperand;
        public Operator Operator;
        public object RightOperand;
        public static Condition Equal => new Condition() { Operator = Operator.Equal };

    }
}

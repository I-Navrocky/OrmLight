using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom
{
    public class Query
    {
        public DalOperation Operation { get; set; }
        public Type EntityType { get; set; }
        public List<ICondition> Conditions { get; set; }
        public List<ISorting> Sortings { get; set; }
        public List<ILimit> Limits { get; set; }

        public Query()
        {
            Conditions = new List<ICondition>();
            Sortings = new List<ISorting>();
            Limits = new List<ILimit>();
        }
    }
}

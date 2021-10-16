using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public interface IQuery
    {
        public DalOperation Operation { get; set; }
        public Type EntityType { get; set; }
        public List<ICondition> Conditions { get; set; }
        public List<ISorting> Sortings { get; set; }
        public List<ILimit> Limits { get; set; }
    }
}

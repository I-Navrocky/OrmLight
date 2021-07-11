using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public interface IQuery<T> : IQueryable<T>
    {
        IEnumerable<IEntity> Entities { get; set; }
        IEnumerable<ICondition> Conditions { get; set; }
        IEnumerable<ISorting> Sortings { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Linq
{
    public interface ICommandQueryable<T>
    {
        Type EntityType { get; }
        IOrmLightQueryProvider Provider { get; }
        IEnumerable<IEntity> Entities { get; set; }
        IEnumerable<ICondition> Conditions { get; set; }
        IEnumerable<ISorting> Sortings { get; set; }
    }
}

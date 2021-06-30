using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmLight;
using OrmLight.Linq;

namespace OrmLight
{
    public class OrmLightCommand<T> : ICommandQueryable<T>
    {
        public Type EntityType { get; private set; }
        public IOrmLightQueryProvider Provider { get; }
        public IEnumerable<IEntity> Entities { get; set; }
        public IEnumerable<ICondition> Conditions { get; set; }
        public IEnumerable<ISorting> Sortings { get; set; }

        public OrmLightCommand(IOrmLightQueryProvider provider)
        {
            EntityType = typeof(T);
            Provider = provider;
            Entities = new List<IEntity>();
            Conditions = new List<ICondition>();
            Sortings = new List<ISorting>();
        }
    }
}

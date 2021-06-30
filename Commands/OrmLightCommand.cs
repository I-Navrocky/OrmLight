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
    public class OrmLightCommand : ICommandQueryable
    {
        public Type EntityType { get; private set; }
        public OrmLightCommand Command { get; private set; }
        public IOrmLightQueryProvider Provider { get; }
        public IEnumerable<IEntity> Entities { get; set; }
        public IEnumerable<ICondition> Conditions { get; set; }
        public IEnumerable<ISorting> Sortings { get; set; }

        public OrmLightCommand(Type type, IOrmLightQueryProvider provider)
        {
            EntityType = type;
            Provider = provider;
            Entities = new List<IEntity>();
            Conditions = new List<ICondition>();
            Sortings = new List<ISorting>();
        }

        //private OrmLightCommand(Type type, IOrmLightQueryProvider provider,
        //    IEnumerable<IEntity> entities,
        //    IEnumerable<ICondition> conditions,
        //    IEnumerable<ISorting> sortings)
        //    : this(type, provider)
        //{
        //    Entities = new List<IEntity>(entities.ToList());
        //    Conditions = new List<ICondition>(conditions.ToList());
        //    Sortings = new List<ISorting>(sortings.ToList());
        //}

        //public ICommandQueryable CreateNewCommand()
        //{
        //    return new OrmLightCommand(EntityType, Provider, Entities, Conditions, Sortings);
        //}

    }
}

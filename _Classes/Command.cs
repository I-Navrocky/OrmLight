using OrmLight.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public class Command<T> where T : BaseEntity
    {
        private List<IEntity> _entities;
        private List<ICondition> _conditions;
        private List<ISorting> _sortings;

        public Command(List<IEntity> entities)
        {
            _entities = entities;
        }

        public Command(IEntity entity) : this(new List<IEntity>() { entity })
        {
        }

        public Command(List<IEntity> entities, List<ICondition> conditions = null, List<ISorting> sortings = null) : this(entities)
        {
            _conditions = conditions;
            _sortings = sortings;
        }
    }
}

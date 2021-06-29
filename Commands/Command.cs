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
    public class Command : ICommandQueryable
    {
        private Type _type;
        private Command _command;
        private IOrmLightQueryProvider _queryProvider;

        public List<IEntity> Entities;
        public List<ICondition> Conditions;
        public List<ISorting> Sortings;
        Command ICommandQueryable.Command => _command;

        public Command(Type type, IOrmLightQueryProvider provider)
        {
            _type = type;
            _queryProvider = provider;
        }

        public ICommandQueryable CreateNewCommand(Command command)
        {
            return new Command(_type, _queryProvider)
            {
                Entities = new List<IEntity>(this.Entities),
                Conditions = new List<ICondition>(this.Conditions),
                Sortings = new List<ISorting>(this.Sortings)
            };
        }

        public TResult Execute<TResult>()
        {
            return _queryProvider.Execute<TResult>(this);
        }

        public IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }
}

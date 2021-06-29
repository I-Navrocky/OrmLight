using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmLight.Linq;

namespace OrmLight.LinqProvider.Linq.QueryProviders
{
    class MySQLQueryProvider : IOrmLightQueryProvider
    {
        private DataAccesLayer _dal;

        public MySQLQueryProvider(DataAccesLayer dal)
        {
            _dal = dal;
        }

        public ICommandQueryable CreateCommand(ICommandQueryable command)
        {
            return new OrmLightCommand(command.EntityType, command.Provider)
            {
                Entities = new List<IEntity>(command.Entities),
                Conditions = new List<ICondition>(command.Conditions),
                Sortings = new List<ISorting>(command.Sortings)
            };
        }

        public TResult Execute<TResult>(ICommandQueryable comm)
        {
            //TODO: в запрос
            throw new NotImplementedException();
        }
    }
}

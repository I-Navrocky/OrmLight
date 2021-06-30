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

        public TResult Execute<TResult>(ICommandQueryable comm)
        {
            //TODO: в запрос
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OrmLight.Linq;

namespace OrmLight.LinqProvider.Linq.QueryProviders
{
    class MySQLQueryProvider : IQueryProvider
    {
        private DataAccesLayer _dal;

        public MySQLQueryProvider(DataAccesLayer dal)
        {
            _dal = dal;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new Query<TElement>(this, expression);
        }

        public TResult Execute<TResult>(IQuery<TResult> comm)
        {
            //TODO: в запрос
            throw new NotImplementedException();
        }

        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }

        public TResult Execute<TResult>(Expression expression)
        {
            throw new NotImplementedException();
        }
    }
}

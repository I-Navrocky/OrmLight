using Newtonsoft.Json.Linq;
using OrmLight.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OrmLight.LinqProvider.Linq.QueryProviders;

namespace OrmLight
{
    public class DataAccesLayer
    {
        private List<IAdapter> _adapters;
        private IQueryProvider _queryProvider;

        //TODO: событие выполнение команды?

        public DataAccesLayer()
        {
            _queryProvider = new MySQLQueryProvider(this);
        }

        public TResult Execute<TResult>(Query<TResult> comm)
        {
            //TODO: интерпретация команды
            throw new NotImplementedException();
        }

        public IQuery<T> Get<T>()
        {
            //return _queryProvider.CreateQuery<T>(Expression.Constant(null, typeof(T)));
            return new Query<T>(_queryProvider, Expression.Constant(new List<T>()));
        }
    }
}

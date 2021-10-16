using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OrmLight.Linq
{
    public class QueryableData<TEntity> : IOrderedQueryable<TEntity>
    {
        //private DataAccessLayerBase _DAL;
        private IQueryProvider _Provider;
        private Expression _Expression;

        public Type ElementType => typeof(TEntity);
        public Expression Expression => _Expression;
        public IQueryProvider Provider => _Provider;

        public QueryableData(DataAccessLayerBase dal, DalOperation operation)
        {
            //_DAL = dal;
            _Provider = new QueryProvider(dal, operation);
            _Expression = Expression.Constant(this);
        }

        public QueryableData(DataAccessLayerBase dal, IQueryProvider provider, Expression expression)
        {
            if (provider == null)
                throw new ArgumentNullException("provider");

            if (expression == null)
                throw new ArgumentNullException("expression");

            if (!typeof(IQueryable<TEntity>).IsAssignableFrom(expression.Type))
                throw new ArgumentOutOfRangeException("expression");

            //_DAL = dal;
            _Provider = provider;
            _Expression = expression;
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return (Provider.Execute<IEnumerable<TEntity>>(_Expression)).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (Provider.Execute<IEnumerable>(_Expression)).GetEnumerator();
        }
    }
}

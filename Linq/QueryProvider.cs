using System;
using System.Linq;
using OrmLight.Linq.Parsing;
using System.Linq.Expressions;

namespace OrmLight.Linq
{
    class QueryProvider : IQueryProvider
    {
        private DataAccessLayerBase _DAL;
        private DalOperation _Operation;

        public QueryProvider(DataAccessLayerBase dal, DalOperation operation)
        {
            _DAL = dal;
            _Operation = operation;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            Type elementType = TypeSystem.GetElementType(expression.Type);

            try
            {
                return (IQueryable)Activator.CreateInstance(
                    typeof(QueryableData<>).MakeGenericType(elementType),
                        new object[] { this, expression });
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public IQueryable<TResult> CreateQuery<TResult>(Expression expression)
        {
            return new QueryableData<TResult>(_DAL, this, expression);
        }

        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }

        public TResult Execute<TResult>(Expression expression)
        {
            TResult result = default(TResult);
            if (ExpressionParser.TryParse(expression, _Operation, out Query query))
                result = _DAL.Execute<TResult>(query);

            return result;
        }
    }
}

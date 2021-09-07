using OrmLight.Custom.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom
{
    public class OrmQueryProvider : IQueryProvider
    {
        private TestDataAccesLayer _DAL;
        private DalOperation _Operation;

        public OrmQueryProvider(TestDataAccesLayer dal, DalOperation operation)
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
            if (ExpressionParser.TryParse(expression, _Operation,  out Query query))
                result = (TResult)_DAL.Execute<RouteEntity>(query);

            return result;
        }
    }
}

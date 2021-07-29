using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Context
{
    public class Query<T> : IQueryable<T>, IQueryable
    {
        private Expression _Expression;
        private IQueryProvider _Provider;

        public Type ElementType => typeof(T);

        public Expression Expression => _Expression;

        public IQueryProvider Provider => _Provider;

        public IEnumerable<IEntity> Entities { get; set; }
        public IEnumerable<ICondition> Conditions { get; set; }
        public IEnumerable<ISorting> Sortings { get; set; }

        public Query(IQueryProvider provider, Expression expresion)
        {
            _Provider = provider;
            _Expression = expresion;
            Entities = new List<IEntity>();
            Conditions = new List<ICondition>();
            Sortings = new List<ISorting>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (this as IQueryable).Provider.Execute<IEnumerator<T>>(_Expression);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IQueryable).Provider.Execute<IEnumerator>(_Expression);
        }
    }
}

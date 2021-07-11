using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OrmLight;
using OrmLight.Linq;

namespace OrmLight
{
    public class Query<T> : IQuery<T>
    {
        public Type ElementType => typeof(T);
        public Expression Expression { get; private set; }
        public IQueryProvider Provider { get; private set; }
        public IEnumerable<IEntity> Entities { get; set; }
        public IEnumerable<ICondition> Conditions { get; set; }
        public IEnumerable<ISorting> Sortings { get; set; }

        public Query(IQueryProvider provider, Expression expression)
        {
            Provider = provider;
            Expression = expression;
            Entities = new List<IEntity>();
            Conditions = new List<ICondition>();
            Sortings = new List<ISorting>();
        }
       
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

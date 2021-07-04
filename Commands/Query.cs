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
    public class Query<T> : IQueryable<T>
    {
        public Type ElementType => typeof(T);
        public Expression Expression { get; private set; }

        public IQueryProvider Provider { get; private set; }

        public Query(IQueryProvider provider, Expression expression)
        {
            Provider = provider;
            Expression = expression;
        }
        //public Type EntityType { get; private set; }
        //public IOrmLightQueryProvider Provider { get; }
        //public IEnumerable<IEntity> Entities { get; set; }
        //public IEnumerable<ICondition> Conditions { get; set; }
        //public IEnumerable<ISorting> Sortings { get; set; }

        //public OrmLightCommand(IQueryProvider provider)
        //{
        //    EntityType = typeof(T);
        //    Provider = provider;
        //    Entities = new List<IEntity>();
        //    Conditions = new List<ICondition>();
        //    Sortings = new List<ISorting>();
        //}
        

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

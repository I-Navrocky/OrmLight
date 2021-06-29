using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public class DataAccesLayer
    {
        private List<IAdapter> _adapters;
        //TODO: событие выполнение команды?

        public DataAccesLayer()
        {
            
        }

        public Command<T> Get<T>(Expression<Func<T, bool>> predicate) where T : BaseEntity
        {
            return new Command<T>();
        }

        //public Command<TSource> Where<TSource>(Expression<Func<TSource, bool>> predicate) where TSource : BaseEntity
        //{
        //    return new Command<TSource>();
        //}
    }
}

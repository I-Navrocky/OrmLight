using Newtonsoft.Json.Linq;
using OrmLight.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public class DataAccesLayer : IOrmLightQueryProvider
    {
        private List<IAdapter> _adapters;
        //TODO: событие выполнение команды?

        public DataAccesLayer()
        {
            
        }

        public TResult Execute<TResult>(Command comm)
        {
            //TODO: интерпретация команды
            throw new NotImplementedException();
        }

        public Command Get<T>()
        {
            return new Command(typeof(T), this);
        }
    }
}

﻿using Newtonsoft.Json.Linq;
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
        //TODO: событие выполнение команды?

        public DataAccesLayer()
        {
            
        }

        public TResult Execute<TResult>(OrmLightCommand<TResult> comm)
        {
            //TODO: интерпретация команды
            throw new NotImplementedException();
        }

        public OrmLightCommand<T> Get<T>()
        {
            return new OrmLightCommand<T>(new MySQLQueryProvider(this));
        }
    }
}

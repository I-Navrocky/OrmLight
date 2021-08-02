﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Context
{
    public abstract class DalContext : IQueryProvider
    {
        //public Type ElementType => typeof(T);
        //public Expression Expression => Expression.Constant(this);
        //public IQueryProvider Provider => this;        

        public IEnumerable<T> Get<T>()
        {
            return new Query<T>(this, Expression.Constant(new List<T>())).AsEnumerable();
        }

        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            // Здесь можно модифицировать
            return new Query<TElement>(this, expression);
        }

        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }

        public abstract TResult Execute<TResult>(Expression expression);
    }
}

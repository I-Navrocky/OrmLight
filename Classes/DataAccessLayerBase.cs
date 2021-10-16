﻿using OrmLight.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OrmLight
{
    public abstract class DataAccessLayerBase
    {
        public abstract QueryableData<TEntity> Get<TEntity>();
        public abstract TResult Execute<TResult>(IQuery query);
    }
}

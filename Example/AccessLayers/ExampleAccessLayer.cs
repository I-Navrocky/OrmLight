using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmLight;
using OrmLight.Linq;
using Example.Entities;

namespace Example.AccessLayers
{
    class ExampleAccessLayer : DataAccessLayerBase
    {
        private Dictionary<Type, List<EntityBase>> _EntityTables = new Dictionary<Type, List<EntityBase>>()
        {
            [typeof(Person)] = new List<EntityBase>()
            {
                new Person() { Id = 0, Name = "John", Age = 33 },
                new Person() { Id = 1, Name = "Jane", Age = 25 },
                new Person() { Id = 2, Name = "Tom", Age = 30 },
                new Person() { Id = 3, Name = "Jerry", Age = 28 }
            },
            [typeof(Position)] = new List<EntityBase>()
            {
                new Position() { Id = 0, Title = "Developer" },
                new Position() { Id = 1, Title = "Engineer" },
                new Position() { Id = 2, Title = "Tester" }
            },
            [typeof(Employee)] = new List<EntityBase>()
            {
                new Employee() { Id = 0,  PersonId = 0, PositionId = 0 },
                new Employee() { Id = 1,  PersonId = 1, PositionId = 0 },
                new Employee() { Id = 2,  PersonId = 2, PositionId = 1 },
                new Employee() { Id = 3,  PersonId = 3, PositionId = 2 }
            }
        };

        public override TResult Execute<TResult>(IQuery query)
        {
            Type t = typeof(TResult);

            try
            {
                object value = null;

                if (query.Operation == DalOperation.Count)
                    value = GetCount(query);

                if (query.Operation == DalOperation.Read)
                    value = GetAll(query);

                if (query.Operation == DalOperation.Create)
                    value = Insert(query);

                if (query.Operation == DalOperation.Update)
                    value = Update(query);

                if (query.Operation == DalOperation.Delete)
                    value = Remove(query);

                return (TResult)Convert.ChangeType(value, t);
            }
            catch (Exception ex)
            {
                // TODO: log
                return default(TResult);
            }            
        }

        public override QueryableData<TEntity> Get<TEntity>()
        {
            return new QueryableData<TEntity>(this, DalOperation.Read);
        }

        public IEnumerable<EntityBase> GetAll(IQuery query)
        {
            try
            {
                if (query == null)
                    return null;

                if (!_EntityTables.TryGetValue(query.EntityType, out List<EntityBase> table))
                    return null;

                foreach (var c in query.Conditions)
                {
                    // TODO: process conditions
                    // table = 
                }

                return table;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetCount(IQuery query)
        {
            throw new NotImplementedException();
        }

        public long[] Insert(IQuery query)
        {
            throw new NotImplementedException();
        }

        public bool Update(IQuery query)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IQuery query)
        {
            throw new NotImplementedException();
        }

    }
}

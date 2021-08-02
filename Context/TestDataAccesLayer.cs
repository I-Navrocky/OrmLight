using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Context
{
    public class TestDataAccesLayer : DalContext
    {
        public override TResult Execute<TResult>(Expression expression)
        {
            var query = new Query<TResult>(this, expression);
            dynamic exp = expression;

            Type t = typeof(TResult);
            throw new NotImplementedException();
            //var enumerator = GetRoutes().GetEnumerator();
        }

        private List<T> GetEntities<T>(Query<T> query)
        {
            return null;
        }

        private List<RouteEntity> GetRoutes()
        {
            return new List<RouteEntity>()
            {
                new RouteEntity() { Id = 1, Name = "М-53"},
                new RouteEntity() { Id = 2, Name = "М-68"},
                new RouteEntity() { Id = 3, Name = "М-88"},
                new RouteEntity() { Id = 4, Name = "М-49"},
                new RouteEntity() { Id = 5, Name = "М-99"},
                new RouteEntity() { Id = 6, Name = "М-65"},
                new RouteEntity() { Id = 7, Name = "М-33"},
                new RouteEntity() { Id = 8, Name = "М-66"},
                new RouteEntity() { Id = 9, Name = "М-77"},
                new RouteEntity() { Id = 10, Name = "М-85"}
            };
        }
    }
}

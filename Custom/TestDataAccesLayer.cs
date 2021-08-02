using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom
{
    public class TestDataAccesLayer
    {
        private List<string> Names = new List<string>
        {
            "Ivan","John","Jack","Mary","Lisa"
        };

        public QueryableData<string> GetString()
        {
            return new QueryableData<String>(this);
        }

        public QueryableData<TEntity> Get<TEntity>()
        {
            return new QueryableData<TEntity>(this);
        }

        public IEnumerable<TEntity> Execute<TEntity>(Query query)
        {
            return new List<TEntity>();
        }

    }
}

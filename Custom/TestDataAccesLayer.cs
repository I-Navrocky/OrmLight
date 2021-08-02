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

        public QueryableData<string> Get()
        {
            return new QueryableData<String>();
        }
    }
}

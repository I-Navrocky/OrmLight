using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Adapters
{
    abstract class BaseAdapter : IAdapter
    {
        //public BaseAdapter(long id) : base(id)
        //{
        //}        
        public AdapterType AdapterType { get; protected set; }
    }
}

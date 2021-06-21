using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public abstract class BaseComponent
    {
        public long Id { get; private set; }

        public BaseComponent(long id)
        {
            Id = id;
        }

        public BaseComponent() : this(-1)
        {
            
        }

        public virtual JObject GetConfiguration()
        {
            var jConf = new JObject();
            jConf["id"] = Id;
            return jConf;
        }
    }
}

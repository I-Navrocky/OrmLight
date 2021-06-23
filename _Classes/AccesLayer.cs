using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public class AccesLayer : BaseComponent, IComponent
    {     
        private List<IAdapter> _adapters;

        //public AccesLayer(long id) : base(id)
        //{
        //}

        //public override JObject GetConfiguration()
        //{
        //    var jConf = base.GetConfiguration();
        //    jConf["adapters"] = JArray.FromObject(_adapters.Select(a => a.GetConfiguration()).ToArray());

        //    return jConf;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public class Sorting : ISorting
    {
        public string FieldName { get; set; }
        public bool IsDesc { get; set; }
    }
}

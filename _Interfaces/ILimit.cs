using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public interface ILimit
    {
        public int Count { get; set; }
        public int Offset { get; set; }
    }
}

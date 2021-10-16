using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmLight;

namespace Example.Entities
{
    class Position : EntityBase
    {
        private string _Title;

        public string Title { get => _Title; set => SetProperty(ref _Title, value); }
    }
}

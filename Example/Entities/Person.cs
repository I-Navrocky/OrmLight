using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmLight;

namespace Example.Entities
{
    class Person : EntityBase
    {
        private string _Name;
        private int _Age;

        public string Name { get => _Name; set => SetProperty(ref _Name, value); }
        public int Age { get => _Age; set => SetProperty(ref _Age, value); }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Commands
{
    public class Sorting : ISorting
    {
        public string FieldName;
        public bool IsDesc;
    }
}

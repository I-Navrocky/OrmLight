using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Custom.Parsing
{
    public class Visitor
    {
        private readonly Expression node;

        public Visitor(Expression node)
        {
            this.node = node;
        }

    }
}

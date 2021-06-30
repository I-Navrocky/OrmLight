using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.Linq
{
    public interface IOrmLightQueryProvider
    {
        //ICommandQueryable CreateCommand(ICommandQueryable command);
        TResult Execute<TResult>(ICommandQueryable comm);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmLight;

namespace Example.Entities
{
    class Employee : EntityBase
    {
        private long _PersonId;
        private long _PositionId;

        public long PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }
        public long PositionId { get => _PositionId; set => SetProperty(ref _PositionId, value); }
    }
}

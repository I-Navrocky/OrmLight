using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight
{
    public abstract class EntityBase
    {
        private Lazy<Dictionary<string, object>> _Properties = new Lazy<Dictionary<string, object>>(() => new Dictionary<string, object>());
        private long _Id;

        public long Id { get => _Id; set => SetProperty(ref _Id, value); }

        protected void SetProperty<T>(ref T oldValue, T newValue, [CallerMemberName] string prop = "")
        {
            if (oldValue == null && newValue == null)
                return;
            else if (oldValue != null && oldValue.Equals(newValue))
                return;

            _Properties.Value[prop] = newValue;
            oldValue = newValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrmLight.test
{
    public abstract class BaseEntity : IEntity//, INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string prop, object newValue)
        {
            //foreach (var prop in props)
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public bool SetProperty<T>(ref T oldValue, T newValue, [CallerMemberName] string prop = "")
        {
            if (oldValue == null && newValue == null)
                return false;
            if (oldValue != null && oldValue.Equals(newValue))
                return false;
            oldValue = newValue;
            OnPropertyChanged(prop, newValue);
            return true;
        }
    }
}

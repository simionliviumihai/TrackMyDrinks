using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyDrinks.Interfaces;

namespace TrackMyDrinks.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged, IVisibleElement
    {
        protected bool isVisible;

        protected virtual void OnVisibilityChanged(bool visibility)
        {
        }

        public bool IsVisible
        {
            get
            {
                return isVisible;
            }

            set
            {
                isVisible = value;
                OnVisibilityChanged(value);
                OnPropertyChanged("IsVisible");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

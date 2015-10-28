using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyDrinks.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TrackMyDrinks.Views.Utils
{
    public class MainPageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Home
        {
            get;
            set;
        }

        public DataTemplate Favorites
        {
            get;
            set;
        }

        public DataTemplate History
        {
            get;
            set;
        }

        public DataTemplate Settings
        {
            get;
            set;
        }

        public DataTemplate Details
        {
            get;
            set;
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is HomeViewModel)
            {
                return Home;
            } 
            else if (item is FavoritesViewModel)
            {
                return Favorites;
            }
            else if (item is HistoryViewModel)
            {
                return History;
            }
            else if (item is SettingsViewModel)
            {
                return Settings;
            }
            else if (item is CategoryDetailsViewModel)
            {
                return Details;
            }
            else
            {
                return null;
            }
        }
    }
}

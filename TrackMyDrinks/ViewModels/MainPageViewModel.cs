using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrackMyDrinks.Interfaces;
using TrackMyDrinks.Utils;
using Windows.UI.Xaml;

namespace TrackMyDrinks.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private int selectedTab;
        private List<IVisibleElement> elements;

        public MainPageViewModel()
        {
            elements = new List<IVisibleElement>();
            elements.Add(new HomeViewModel());
            elements.Add(new FavoritesViewModel());
            elements.Add(new HistoryViewModel());
            elements.Add(new SettingsViewModel());
            LevelHandler.Instance.Push(elements.First());

            LevelHandler.Instance.LevelChanged += new LevelChangedDelegate(OnLevelChanged);
        }

        private void OnLevelChanged()
        {
            VisibleElement = LevelHandler.Instance.Top;
        }

        public IVisibleElement VisibleElement
        {
            get
            {
                return LevelHandler.Instance.Top;
            }

            set
            {
                OnPropertyChanged("VisibleElement");
            }
        }
 
        public int SelectedTab
        {
            get
            {
                return selectedTab;
            }

            set
            {
                selectedTab = value;
                LevelHandler.Instance.Pop(LevelHandler.Instance.CurrentLevel - 1);
                LevelHandler.Instance.Replace(elements.ElementAt(value));
            }
        }

        public void GoBack()
        {
            HandleGoBack();
        }

        public bool HandleGoBack()
        {
            return LevelHandler.Instance.Pop(1);
        }
    }
}

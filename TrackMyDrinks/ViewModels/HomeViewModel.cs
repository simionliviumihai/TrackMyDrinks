using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrackMyDrinks.DataModels;
using TrackMyDrinks.Interfaces;
using TrackMyDrinks.Utils;
using Windows.UI.Xaml;

namespace TrackMyDrinks.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private HomeDataModel dataModel;

        public HomeViewModel()
        {
            this.dataModel = new HomeDataModel();
            this.Items = new List<IVisibleElement>();
            foreach (var category in this.dataModel.Categories)
            {
                this.Items.Add(new LightCategoryViewModel(category));
            }
        }

        public List<IVisibleElement> Items
        {
            get;
            private set;
        }

        public int SelectedItemIndex
        {
            get
            {
                return -1;
            }

            set
            {
                LevelHandler.Instance.Push(
                    new CategoryDetailsViewModel(this.dataModel.Categories.ElementAt(value)));
            }
        }
    }
}

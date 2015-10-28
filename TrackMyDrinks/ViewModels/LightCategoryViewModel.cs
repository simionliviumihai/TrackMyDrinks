using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyDrinks.DataModels;

namespace TrackMyDrinks.ViewModels
{
    public class LightCategoryViewModel : BaseViewModel
    {
        private CategoryDataModel dataModel;
        public LightCategoryViewModel(CategoryDataModel dataModel)
        {
            this.dataModel = dataModel;
        }
        public String Name
        {
            get
            {
                return dataModel.Name;
            }
        }

        public string ImagePath
        {
            get
            {
                return dataModel.ImagePath;
            }
        }
    }
}

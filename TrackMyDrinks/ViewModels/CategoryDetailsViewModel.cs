using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyDrinks.DataModels;

namespace TrackMyDrinks.ViewModels
{
    public class CategoryDetailsViewModel : 
        BaseViewModel
    {
        private CategoryDataModel dataModel;
         
        public CategoryDetailsViewModel(CategoryDataModel category)
        {
            this.dataModel = category;
        }

        public string Name
        {
            get
            {
                return this.dataModel.Name;
            }
        }
    }
}

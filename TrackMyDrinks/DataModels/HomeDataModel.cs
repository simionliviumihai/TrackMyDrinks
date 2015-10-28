using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackMyDrinks.DataModels
{
    public class HomeDataModel
    {
        public HomeDataModel()
        {
            var factory = new CategoryDataModelFactory();

            this.Categories = new List<CategoryDataModel>();
            this.Categories.Add(factory.CreateCategoryDataModel(CategoryType.Beer));
            this.Categories.Add(factory.CreateCategoryDataModel(CategoryType.Wine));
            this.Categories.Add(factory.CreateCategoryDataModel(CategoryType.Cocktails));
            this.Categories.Add(factory.CreateCategoryDataModel(CategoryType.Spirits));
        }

        public List<CategoryDataModel> Categories
        {
            get;
            private set;
        }
    }
}

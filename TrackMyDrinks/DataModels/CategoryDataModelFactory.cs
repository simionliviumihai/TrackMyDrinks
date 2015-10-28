using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackMyDrinks.DataModels
{
    public enum CategoryType
    {
        Beer,
        Wine,
        Cocktails,
        Spirits,
    }

    public class CategoryDataModelFactory
    {
        public CategoryDataModel CreateCategoryDataModel(CategoryType type)
        {
            switch (type)
            {
                case CategoryType.Beer:
                    return CategoryDataModel.CreateAndInitialize(
                        "Beer",
                        "/Assets/drinks/beer.png");
                case CategoryType.Wine:
                    return CategoryDataModel.CreateAndInitialize(
                        "Wine",
                        "/Assets/drinks/red_wine.png");
                case CategoryType.Cocktails:
                    return CategoryDataModel.CreateAndInitialize(
                        "Cocktails",
                        "/Assets/drinks/cocktail.png");
                case CategoryType.Spirits:
                    return CategoryDataModel.CreateAndInitialize(
                        "Spirits",
                        "/Assets/drinks/whiskey.png");
                default:
                    throw new InvalidCastException("Unknown category");
            }
        }
    }
}

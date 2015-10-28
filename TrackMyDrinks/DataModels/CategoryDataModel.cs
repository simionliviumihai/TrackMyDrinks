using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackMyDrinks.DataModels
{
    public class CategoryDataModel
    {
        private CategoryDataModel()
        {
        }

        static public CategoryDataModel CreateAndInitialize(
            string name,
            string imagePath)
        {
            CategoryDataModel newObject = new CategoryDataModel();
            newObject.Name = name;
            newObject.ImagePath = imagePath;
            return newObject;
        }

        public string Name
        {
            get;
            private set;
        }

        public string ImagePath
        {
            get;
            private set;
        }
    }
}

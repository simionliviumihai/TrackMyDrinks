using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TrackMyDrinks.Utils;
using TrackMyDrinks.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TrackMyDrinks.Views.Controls
{
    public sealed partial class LightCategory : UserControl
    {
        public LightCategory()
        {
            this.InitializeComponent();
        }

        public LightCategoryViewModel ViewModel
        {
            get
            {
                return LevelHandler.Instance.Top as LightCategoryViewModel;
            }
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            throw new InvalidOperationException(e.ErrorMessage);
        }
    }
}

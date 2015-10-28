using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
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
    public sealed partial class Home : UserControl
    {
        public Home()
        {
            this.InitializeComponent();
        }

        public HomeViewModel ViewModel
        {
            get
            {
                return LevelHandler.Instance.Top as HomeViewModel;
            }
        }
    }
}

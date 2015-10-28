using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TrackMyDrinks.Utils;
using TrackMyDrinks.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TrackMyDrinks
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private MainPageViewModel viewModel;
       
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainPage()
        {
            this.InitializeComponent();

            viewModel = new MainPageViewModel();

            LevelHandler.Instance.LevelChanged += new LevelChangedDelegate(OnLevelChanged);
        }

        public Visibility SoftwareBackVisibility
        {
            get
            {
                return ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons") ? 
                    Visibility.Collapsed : Visibility.Visible;
            }
        }

        private void HardwareButtons_BackPressed(
            object sender, 
            Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = viewModel.HandleGoBack();
            PropertyChanged(this, new PropertyChangedEventArgs("IsBackEnabled"));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                Windows.Phone.UI.Input.HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainView.IsPaneOpen = !mainView.IsPaneOpen;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl.Visibility == Visibility.Visible)
            {
                mainView.IsPaneOpen = false;
            }
        }

        public MainPageViewModel ViewModel
        {
            get
            {
                return viewModel;
            }
        }

        private void OnLevelChanged()
        {
            PropertyChanged(this, new PropertyChangedEventArgs("IsBackEnabled"));
        }

        public bool IsBackEnabled
        {
            get
            {
                return LevelHandler.Instance.CurrentLevel > 1;
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.HandleGoBack();
        }
    }
}

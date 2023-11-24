using AppStore.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AppStore.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void myappuwp(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void myappuwpltsc(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void uteuwp(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
            Frame.Navigate(typeof(UTEUWPPage));
        
    }
}

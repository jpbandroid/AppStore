using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppStore.UserControls;
public sealed partial class AppListingControl : UserControl
{
    public AppListingControl()
    {
        this.InitializeComponent();
    }

    public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(
        "Title", // The name of the property
        typeof(string), // The type of the property
        typeof(AppListingControl), // The type of the owner class
        new PropertyMetadata("Title") // Default value
        );

    [Browsable(true)]
    [Category("Common")]
    [Description("The title of the app listing")]
    public string Title
    {
        get
        {
            return (string)GetValue(TitleProperty);
        }
        set
        {
            SetValue(TitleProperty, value);
        }
    }
}

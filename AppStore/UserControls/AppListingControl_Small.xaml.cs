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
public sealed partial class AppListingControl_Small : UserControl
{
    public AppListingControl_Small()
    {
        this.InitializeComponent();
    }

    public static readonly DependencyProperty AppTitleProperty =
        DependencyProperty.Register(
        "AppTitle", // The name of the property
        typeof(string), // The type of the property
        typeof(AppListingControl_Small), // The type of the owner class
        new PropertyMetadata("AppTitle", AppTitleChanged) // Default value
        );

    [Browsable(true)]
    [Category("Common")]
    [Description("The title of the app listing")]
    public string AppTitle
    {
        get
        {
            return (string)GetValue(AppTitleProperty);
        }
        set
        {
            SetValue(AppTitleProperty, value);
        }
    }

    private static void AppTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((AppListingControl_Small)d).DetectTitleChange();
    }

    public void DetectTitleChange()
    {
        TitleBlock.Text = AppTitle;
    }

    public static readonly DependencyProperty AppDescriptionProperty =
        DependencyProperty.Register(
        "AppDescription", // The name of the property
        typeof(string), // The type of the property
        typeof(AppListingControl_Small), // The type of the owner class
        new PropertyMetadata("AppDescription", AppDescriptionChanged) // Default value
        );

    [Browsable(true)]
    [Category("Common")]
    [Description("The description of the app listing")]
    public string AppDescription
    {
        get
        {
            return (string)GetValue(AppDescriptionProperty);
        }
        set
        {
            SetValue(AppDescriptionProperty, value);
        }
    }

    private static void AppDescriptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((AppListingControl_Small)d).DetectDescriptionChange();
    }

    public void DetectDescriptionChange()
    {
        DescriptionBlock.Text = AppDescription;
    }
}

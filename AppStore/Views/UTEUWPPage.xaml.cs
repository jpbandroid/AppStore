using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using CommunityToolkit.WinUI.Notifications;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.System;
using Windows.Foundation;
using Windows.Networking.BackgroundTransfer;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppStore.Views;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class UTEUWPPage : Page
{
    public UTEUWPPage()
    {
        this.InitializeComponent();
        Uri sourcetext = new Uri("https://github.com/jpbandroid/AppStore-Resources/raw/main/UltraTextEdit%20UWP/dev_version.txt");
        WebClient client = new WebClient();
        client.DownloadFile(sourcetext, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/UTE-dev-version.txt");
        // Use it on your StreamReader
        var filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/UTE-dev-version.txt";
        StreamReader sr = new StreamReader(filename);
        versiontext.Text = "version " + sr.ReadToEnd();
    }

    private void hyperlinkclick(object sender, RoutedEventArgs e)
    {

    }

    private async void download(object sender, RoutedEventArgs e)
    {
        string name = Environment.UserName;
        using var client = new HttpClient();
        using var s = await client.GetStreamAsync("https://github.com/jpbandroid/AppStore-Resources/raw/main/UltraTextEdit%20UWP/UltraTextEdit%20UWP_10.0.25915.1000_x86_x64_arm_arm64.msixbundle");
        using var fs = new FileStream("C:\\Users\\"+name+"\\Downloads\\UTEUWP.msixbundle", FileMode.OpenOrCreate);
        await s.CopyToAsync(fs);
        new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)
            .AddText("UltraTextEdit UWP download complete")
            .AddText("Take a look!")
            .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 5, your TFM must be net5.0-windows10.0.17763.0 or greater

    }
}

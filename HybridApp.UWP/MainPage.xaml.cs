using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using HybridApp.Library;

namespace HybridApp.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnNavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            MessageHelper messageHelper = new MessageHelper();
            sender.AddWebAllowedObject("messageHelper", messageHelper);

            NavigationHelper navigationHelper = new NavigationHelper();
            sender.AddWebAllowedObject("navigationHelper", navigationHelper);
        }
    }
}

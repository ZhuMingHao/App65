using App65.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

[assembly: Xamarin.Forms.Dependency(typeof(GoBackImplementation))]

namespace App65.UWP
{
    public class GoBackImplementation : IGoBack
    {
        public void GoBack()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame != null)
            {
                rootFrame = new Frame();
                rootFrame.NavigationFailed += RootFrame_NavigationFailed;

                Window.Current.Content = rootFrame;
            }
            if (rootFrame.Content == null)
            {
                rootFrame.Navigate(typeof(MainPage));
            }
        }

        private void RootFrame_NavigationFailed(object sender, Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ShegzstuffPC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(JambCBT));
            TitleTextBock.Text = "Jamb";
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MonSplitview.IsPaneOpen = !MonSplitview.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (JambCBT.IsSelected)
            {
                MyFrame.Navigate(typeof(JambCBT));
                TitleTextBock.Text = "Jamb";
            }
            else if (WaecTest.IsSelected)
            {
                MyFrame.Navigate(typeof(WaecTest));
                TitleTextBock.Text = "Waec";
            }
            else if (NecoTest.IsSelected)
            {
                MyFrame.Navigate(typeof(Neco));
                TitleTextBock.Text = "Neco";
            }

            else if (NabtebTest.IsSelected)
            {
                MyFrame.Navigate(typeof(Nabteb));
                TitleTextBock.Text = "Nabteb";
            }
            else if (Materials.IsSelected)
            {
                MyFrame.Navigate(typeof(Materials));
                TitleTextBock.Text = "Materials";
            }
        }

        private void ContactUS_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(ContactUs));
            TitleTextBock.Text = "Contact Us";
            
            
        }

        private void HighScore_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(HighScore));
            TitleTextBock.Text = "High Score";
        }
    }
}

using ShegzstuffPC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShegzstuffPC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Admin : Page
    {
        private bool add;
        public Admin(bool add)
        {
            this.add = add;
            this.InitializeComponent();
            if (add)
            {
                Title.Text = "Connected";
            }
            else
            {
                Title.Text = "Not Connected";
            }
        }

        private void SigninButton_Click(object sender, RoutedEventArgs e)
        {
            if (AdminPassword.Password == "9_rm&wqhhD9@XC+-")
            {
                Passwordchecker.Visibility = Visibility.Collapsed;
                DetailsStackPannel.Visibility = Visibility.Visible;
                ChangeURLStackpannel.Visibility = Visibility.Visible;
                PasswordStackpanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                Passwordchecker.Visibility = Visibility.Visible;
            } 
        }

        private void CHangeUrlButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentWHatsappTextBlock.Text = ChangeWHatsappTextBox.Text;
        }
    }
}

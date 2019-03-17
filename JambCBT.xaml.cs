using ShegzstuffPC.Models;
using ShegzstuffPC.zeLists;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShegzstuffPC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class JambCBT : Page
    {
        public string walter = "http//outlook.com";
        string selectedPaperVersion = "V1";
        

        public JambCBT()
        {
            
            this.InitializeComponent();
            Whatsappjoin.NavigateUri = new Uri( "https://chat.whatsapp.com/HPmOUETUtWr9K0LzMhUHBz");
            List<PaperType> zePapertypes = PaperVersionList.LoadPaperType();
            List<PaperVer> zePaperver = VerList.LoadVer();
            var VersionList = zePaperver.OrderBy(x => x.version).ToList().Select(x => x.version);
            var SubjectLists = zePapertypes.Where(x => x.PaperVersion == selectedPaperVersion).OrderBy(x => x.Subject).ToList().Select(x => x.Subject);
            Changesubject.Visibility = Visibility.Collapsed;
            SelectVersion.ItemsSource = VersionList;
            Changesubject.ItemsSource = SubjectLists;
            


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(QUestionerePage));


        }

        private void JambBrochureButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Materials));
        }

        private void JambsylabButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Materials));
        }



        private void JambResult_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(JambResult));
        }

        private void SelectVersion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPaperVersion = SelectVersion.SelectedItem.ToString();
            Changesubject.Visibility = Visibility.Visible;
            

        }

    }
}

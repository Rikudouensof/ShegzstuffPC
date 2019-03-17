using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Pdf;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShegzstuffPC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Materials : Page
    {

        string zeUri = " ";

        

        public Materials()
        {
            this.InitializeComponent();
            this.DataContext = this;

            EnglishButton.Content = "English \n past \n question \n (jamb)";
            MathButton.Content = "Maths \n past \n question \n (jamb)";
            physicsButton.Content = "Maths \n past \n question \n (jamb)";
            BiologyButton.Content = "Biology \n past \n question \n (jamb)";
            ChemistryButton.Content = "Chemistry \n past \n question \n (jamb)";
            EconsButton.Content = "Economics \n past \n question \n (jamb)";
            GovernmentButton.Content = "Government \n past \n question \n (jamb)";
            AccountButton.Content = "Account \n past \n question \n (jamb)";
            CommerceButton.Content = "Comercerce \n past \n question \n (jamb)";
            CRKButton.Content = "CRK \n past \n question \n (jamb)";
            MathButton2.Content = "Maths 2 \n past \n question \n (jamb)";


        }


        public async void OpenLocal()
        {
            StorageFile f = await
                StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/PDF/Government.pdf"));
            PdfDocument doc = await PdfDocument.LoadFromFileAsync(f);

            Load(doc);
        }

        public async void OpenRemote()
        {
            HttpClient client = new HttpClient();
            var stream = await
                client.GetStreamAsync(zeUri);
            var memStream = new MemoryStream();
            await stream.CopyToAsync(memStream);
            memStream.Position = 0;
            PdfDocument doc = await PdfDocument.LoadFromStreamAsync(memStream.AsRandomAccessStream());

            Load(doc);
        }

        async void Load(PdfDocument pdfDoc)
        {
            PdfPages.Clear();

            for (uint i = 0; i < pdfDoc.PageCount; i++)
            {
                BitmapImage image = new BitmapImage();

                var page = pdfDoc.GetPage(i);

                using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
                {
                    await page.RenderToStreamAsync(stream);
                    await image.SetSourceAsync(stream);
                }

                PdfPages.Add(image);
            }
        }

        public ObservableCollection<BitmapImage> PdfPages
        {
            get;
            set;
        } = new ObservableCollection<BitmapImage>();






        private void EnglishButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=be50f7b3f79c9e9c24de666a65fdf90e";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();
        }

        private void MathButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=f9c4f0330adba579e740c5a8e6ed433f";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();


        }

        private void EconsButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=1ee713cd73d7e5ca4676c1f37bfd920d";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();
        }

        private void physicsButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://uc8af94216a21e58ae9ff905570e.dl.dropboxusercontent.com/cd/0/get/AcoU8LozyQsPtrx-eFhAGcyXrWhonCM8b9MwVqYBEam96HylEVtXkMAhW43EvXgzMGIJXJUultkkJdIz95jPuj--59iXfZuDQlbxBUzHZ8n9WQ/file?dl=1";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();

        }

        private void ChemistryButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=e78bece0f5d6e4b8388c7d08a28daeb5";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();

        }

        private void GovernmentButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=fee0dca831ff937752d71ba71b13f55b";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();

        }

        private void BiologyButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=5fce41774fd14124d2d3474e9fda82fa";
            pdfViewer.Visibility = Visibility.Visible;
            OpenRemote();
        }

        private void CommerceButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://uc8af94216a21e58ae9ff905570e.dl.dropboxusercontent.com/cd/0/get/AcoU8LozyQsPtrx-eFhAGcyXrWhonCM8b9MwVqYBEam96HylEVtXkMAhW43EvXgzMGIJXJUultkkJdIz95jPuj--59iXfZuDQlbxBUzHZ8n9WQ/file?dl=1";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();

        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=5faf11f0ee39e88f9a85f2ea1bb8e4ea";
            pdfViewer.Visibility = Visibility.Visible;
            OpenRemote();
        }

        private void CRKButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=bce50af81f6d63a4bf0a975fb00ebd9c";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();

        }


        private void JambsylabButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=d9e631ae85050db304bb9ef2fb4bc8b8";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();

        }

        private void JambbrocureButton_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=4228210eb5f21337d51f1fdd852dcbcd";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();

        }
        private void Colapseview()
        {
            EnglishButton.Visibility = Visibility.Collapsed;
            MathButton.Visibility = Visibility.Collapsed;
            JambbrocureButton.Visibility = Visibility.Collapsed;
            JambsylabButton.Visibility = Visibility.Collapsed;
            physicsButton.Visibility = Visibility.Collapsed;
            BiologyButton.Visibility = Visibility.Collapsed;
            ChemistryButton.Visibility = Visibility.Collapsed;
            EconsButton.Visibility = Visibility.Collapsed;
            GovernmentButton.Visibility = Visibility.Collapsed;
            AccountButton.Visibility = Visibility.Collapsed;
            CommerceButton.Visibility = Visibility.Collapsed;
            CRKButton.Visibility = Visibility.Collapsed;
        }

        private void MathButton2_Click(object sender, RoutedEventArgs e)
        {
            zeUri = "https://www.pdfhost.net/index.php?Action=DownloadFile&id=566ed018a69aeee78fa47a158d95f82f";
            pdfViewer.Visibility = Visibility.Visible;
            Colapseview();
            OpenRemote();
        }

       
    }
}

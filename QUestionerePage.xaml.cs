using ShegzstuffPC.Models;
using ShegzstuffPC.zeLists;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static ShegzstuffPC.JambCBT;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShegzstuffPC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QUestionerePage : Page
    {





        public string isQUery;
        int presentNumber = 1;
        int score= 00;
        string diolugScore, correctAns, zeVersion = "V1", zeSubjects;
        int _minCountdown;
        int _secCountdown = 5;
        string selectedPaperVersion = "English";
        DispatcherTimer dispatcherTimer;
        List<TestExam> allquestions = ZeQuestionsList.LoaQUestions();
        public QUestionerePage()

        {
            this.InitializeComponent();



            ResultTextBox.Visibility = Visibility.Collapsed;
            RetakeQuestionButton.Visibility = Visibility.Collapsed;

            dispatcherTimer = new DispatcherTimer();
            TimerMin.Text = _minCountdown.ToString();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);




            List<PaperVer> zePaperver = VerList.LoadVer();
            var VersionList = zePaperver.OrderBy(x => x.version).ToList().Select(x => x.version);
            ChangeVersion.ItemsSource = VersionList;
        }





        async void DispatcherTimer_Tick(object sender, object e)
        {
            TimerSec.Text = _secCountdown--.ToString();

            TimerMin.Text = _minCountdown.ToString();
            TimerSec.Text = _secCountdown.ToString();
            if (_secCountdown == 0 && _minCountdown > 0)
            {



                _secCountdown = _secCountdown + 59;
                _minCountdown--;



                TimerMin.Text = _minCountdown.ToString();
            }
            else if (_secCountdown == -1 && _minCountdown == 0)
            {
               

                var massage = new MessageDialog("Do you want to share or save your score?", diolugScore);
                var shareButton = new UICommand("Share");
                var saveButton = new UICommand("Save");
                var cancelButton = new UICommand("No");
                massage.Commands.Add(shareButton);
                massage.Commands.Add(saveButton);
                massage.Commands.Add(cancelButton);
                IUICommand result = await massage.ShowAsync();

                if (result != null && result.Label.Equals("Share"))
                {

                }
                else if (result != null && result.Label.Equals("Save"))
                {
                    List<Highscore> highscores = new List<Highscore>
                    {
                        new Highscore{Date = DateTime.Now.ToString(), Subject = SubjectTextBox.Text.ToString(), Score = score }
                    };
                }
                dispatcherTimer.Stop();

                InstructionTextBox.Visibility = Visibility.Collapsed;
                QuestionStackpannel.Visibility = Visibility.Collapsed;
                OptionsStackpannel.Visibility = Visibility.Collapsed;
                Next.Visibility = Visibility.Collapsed;
                Previous.Visibility = Visibility.Collapsed;
                ResultTextBox.Visibility = Visibility.Visible;
                RetakeQuestionButton.Visibility = Visibility.Visible;

            }



        }

        private string SetQuestion(int ID)
        {

            allquestions = allquestions.Where(x => x.Version == zeVersion).Where(x => x.Subject == zeSubjects).ToList();
            TestExam z = allquestions.Where(x => x.ID == ID).SingleOrDefault();

            Int32.TryParse(TotalqustionNumber.Text, out _minCountdown);

            QuestionNmber.Text = presentNumber.ToString();
            TotalqustionNumber.Text = allquestions.Count.ToString();
            dispatcherTimer.Start();

            QuestionTextBox.Text = z.Question;
            SubjectTextBox.Text = z.Subject;
            InstructionTextBox.Text = z.Instructon;


            if (!z.QuestionImage.Equals(""))
            {
                questionImage.Source = new BitmapImage(new Uri(z.QuestionImage, UriKind.Absolute));
            }
            else
            {
                questionImage.Visibility = Visibility.Collapsed;
                QuestionTextBox.Width = 700;
            }

            option1checkbox.Content = z.Option1;
            option2checkbox.Content = z.Option2;
            option3checkbox.Content = z.Option3;
            option4checkbox.Content = z.Option4;
            option5checkbox.Content = z.Option5;
            if (option5checkbox.Content.Equals(""))
            {
                option5checkbox.Visibility = Visibility.Collapsed;
            }
            else if (z.Instructon.Equals(""))
            {
                InstructionTextBox.Visibility = Visibility.Collapsed;
            }


            correctAns = z.QuestionAnswer;
            ResultTextBox.Text = ResultTextBox.Text + '\n' + presentNumber.ToString() + '\t' + z.Question + " \n \n" + "Answer: " + z.QuestionAnswer + " \n \n";
            return correctAns;
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {

            if (score > 0)
            {
                score--;
            }
            if (presentNumber > 1)
            {
                presentNumber--;
                SetQuestion(presentNumber);
            }


        }

        private void Changesubject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Start.Visibility = Visibility.Visible;

        }

        private void ChangeVersion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<PaperType> zePapertypes = PaperVersionList.LoadPaperType();
            selectedPaperVersion = ChangeVersion.SelectedItem.ToString();
            var SubjectLists = zePapertypes.Where(x => x.PaperVersion == selectedPaperVersion).OrderBy(x => x.Subject).ToList().Select(x => x.Subject);
            Changesubject.ItemsSource = SubjectLists;

            Changesubject.Visibility = Visibility.Visible;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            zeSubjects = Changesubject.SelectedItem.ToString();
            SetQuestion(presentNumber);
            QuestionStackpannel.Visibility = Visibility.Visible;
            ButtonsScrolviewer.Visibility = Visibility.Visible;
            Start.Visibility = Visibility.Collapsed;
            Changesubject.Visibility = Visibility.Collapsed;
            Submit.Visibility = Visibility.Visible;
            QuestionNmber.Visibility = Visibility.Visible;
            OptionsStackpannel.Visibility = Visibility.Visible;
            Restart.Visibility = Visibility.Visible;
            ChangeVersion.Visibility = Visibility.Collapsed;

        }

        private void ChangeVersion_Tapped(object sender, TappedRoutedEventArgs e)
        {
            List<PaperType> zePapertypes = PaperVersionList.LoadPaperType();
            var SubjectLists = zePapertypes.Where(x => x.PaperVersion == selectedPaperVersion).OrderBy(x => x.Subject).ToList().Select(x => x.Subject);
            Changesubject.ItemsSource = SubjectLists;
            Changesubject.Visibility = Visibility.Visible;
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            presentNumber = 1;
            score = 0;
            SetQuestion(presentNumber);
            QuestionNmber.Text = presentNumber.ToString();
            TotalqustionNumber.Text = allquestions.Count.ToString();
            ResultTextBox.Visibility = Visibility.Collapsed;
            RetakeQuestionButton.Visibility = Visibility.Collapsed;
            QuestionStackpannel.Visibility = Visibility.Visible;
            ButtonsScrolviewer.Visibility = Visibility.Visible;
            Start.Visibility = Visibility.Collapsed;
            Changesubject.Visibility = Visibility.Collapsed;
            Submit.Visibility = Visibility.Visible;
            QuestionNmber.Visibility = Visibility.Visible;
            OptionsStackpannel.Visibility = Visibility.Visible;
            Restart.Visibility = Visibility.Visible;
            ChangeVersion.Visibility = Visibility.Collapsed;
            ButtonsScrolviewer.Visibility = Visibility.Visible;
            Previous.Visibility = Visibility.Visible;
            Next.Visibility = Visibility.Visible;
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
           

            var massage = new MessageDialog("Do you want to share or save your score?", diolugScore);
            var shareButton = new UICommand("Share");
            
            var cancelButton = new UICommand("No");
            massage.Commands.Add(shareButton);
            
            massage.Commands.Add(cancelButton);
            IUICommand result = await massage.ShowAsync();

            if (result != null && result.Label.Equals("Share"))
            {
                
            }

            InstructionTextBox.Visibility = Visibility.Collapsed;
            QuestionStackpannel.Visibility = Visibility.Collapsed;
            OptionsStackpannel.Visibility = Visibility.Collapsed;
            Next.Visibility = Visibility.Collapsed;
            Previous.Visibility = Visibility.Collapsed;
            ResultTextBox.Visibility = Visibility.Visible;
            RetakeQuestionButton.Visibility = Visibility.Visible;

            dispatcherTimer.Stop();

        }

        private void RetakeQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            presentNumber = 1;
            score = 0;
            SetQuestion(presentNumber);
            QuestionNmber.Text = presentNumber.ToString();
            TotalqustionNumber.Text = allquestions.Count.ToString();
            ResultTextBox.Visibility = Visibility.Collapsed;
            RetakeQuestionButton.Visibility = Visibility.Collapsed;
            QuestionStackpannel.Visibility = Visibility.Visible;
            ButtonsScrolviewer.Visibility = Visibility.Visible;
            Start.Visibility = Visibility.Collapsed;
            Changesubject.Visibility = Visibility.Collapsed;
            Submit.Visibility = Visibility.Visible;
            QuestionNmber.Visibility = Visibility.Visible;
            OptionsStackpannel.Visibility = Visibility.Visible;
            Restart.Visibility = Visibility.Visible;
            ChangeVersion.Visibility = Visibility.Collapsed;
            ButtonsScrolviewer.Visibility = Visibility.Visible;
            Previous.Visibility = Visibility.Visible;
            Next.Visibility = Visibility.Visible;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

            if (option1checkbox.IsChecked == true && option1checkbox.Content.Equals(correctAns))
            {
                score = score + 1;
            }
            else if (option2checkbox.IsChecked == true && option2checkbox.Content.Equals(correctAns))
            {
                score = score + 1;
            }
            else if (option3checkbox.IsChecked == true && option3checkbox.Content.Equals(correctAns))
            {
                score = score + 1;
            }
            else if (option4checkbox.IsChecked == true && option4checkbox.Content.Equals(correctAns))
            {
                score = score + 1;
            }
            else if (option5checkbox.IsChecked == true && option5checkbox.Content.Equals(correctAns))
            {
                score = score + 1;
            }
            else
            {

            }
            diolugScore = score.ToString();
            presentNumber++;
            SetQuestion(presentNumber);
            QuestionNmber.Text = presentNumber.ToString();

            if (QuestionNmber.Text.Equals(TotalqustionNumber.Text))
            {
                InstructionTextBox.Visibility = Visibility.Collapsed;
                QuestionStackpannel.Visibility = Visibility.Collapsed;
                OptionsStackpannel.Visibility = Visibility.Collapsed;
                Next.Visibility = Visibility.Collapsed;
                Previous.Visibility = Visibility.Collapsed;
                ResultTextBox.Visibility = Visibility.Visible;
                RetakeQuestionButton.Visibility = Visibility.Visible;
            }
            option1checkbox.IsChecked = !option1checkbox.IsChecked;
            option2checkbox.IsChecked = !option2checkbox.IsChecked;
            option3checkbox.IsChecked = !option3checkbox.IsChecked;
            option4checkbox.IsChecked = !option4checkbox.IsChecked;
            option5checkbox.IsChecked = !option5checkbox.IsChecked;


        }

       
    }
}

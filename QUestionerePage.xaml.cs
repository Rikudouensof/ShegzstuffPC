using ShegzstuffPC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class QUestionerePage : Page
    {

        List<TestExam> allquestions = new List<TestExam>
        {
            new TestExam {ID = 1, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "There is some obvious \"symmetry\" in the whole presentation", QuestionAnswer="orderliness", Option1="confusion", Option2="hesitation", Option3="excitement", Option4="orderliness", Option5="dissatisfaction"  },
            new TestExam {ID = 2, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "The state government appointed a \"commission of inquiry\" to go into the community's complaints carefully and without prejudice", QuestionAnswer="investigate", Option1="investigate", Option2="search", Option3="look for", Option4="account for", Option5="ascertain"  },
            new TestExam {ID = 3, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "All his plans \"fell through\" ", QuestionAnswer="failed ", Option1="failed", Option2="were accomplished", Option3="had to be reviewed", Option4="were rejected", Option5="fell"  },
            new TestExam {ID = 4, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "The balance sheet at the end of the business year shows that we \"broke even\"", QuestionAnswer="neither lost nor gained", Option1="lost heavily", Option2="made profit", Option3="neither lost nor gained", Option4="had no money to continue business", Option5="were heavily indebted to our bankers"  },
            new TestExam {ID = 5, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "The result of his experiment represents a \"break through\" in medical science", QuestionAnswer="an outstanding success", Option1="an outstanding success", Option2="catastrophe", Option3="an end to such experiments", Option4="breaking point", Option5="a colossal failure"  },
            new TestExam {ID = 6, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "He \"stared\" at her", QuestionAnswer="gazed ", Option1="glanced", Option2="peeped", Option3="looked", Option4="gazed ", Option5="fixed"  },
            new TestExam {ID = 7, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "The two sprinters were running \"neck and neck\"", QuestionAnswer="exactly level", Option1="exactly level", Option2="very slowly", Option3="very fast", Option4="with their necks together", Option5="together"  },
            new TestExam {ID = 8, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "His jail terms were to run \"concurrently\" ", QuestionAnswer="simultaneously", Option1="simultaneously", Option2="uniformly", Option3="laboriously", Option4="consecutively", Option5="judiciously"},
            new TestExam {ID = 9, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "Mr. Jack could be a successful businessman if he paid more attention to the \"more intricate aspects\" of his account", QuestionAnswer="Jack will have a very good chance of succeeding ", Option1="Mr Jack will undoubtedly succeed", Option2="Mr Jack cannot succeed", Option3="Mr. Jack will find it difficult to succeed", Option4="Mr. Jack will find it difficult to succeed", Option5="Mr Jack will succeed in spite of all odds"  },
            new TestExam {ID = 10, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "He was appointed specifically to \"put the recruits through\"", QuestionAnswer="train them", Option1="assign them to work", Option2="train them", Option3="discipline them", Option4="assist them at work", Option5="supervise them at work"  },
            new TestExam {ID = 11, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "He spoke with his \"heart in his mouth\"", QuestionAnswer="with fright and agitation", Option1="courageously", Option2="with such unusual cowardice", Option3="with a lot of confusion in his speech", Option4="without being able to make up his mind", Option5="with fright and agitation"  },
            new TestExam {ID = 12, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "The bill has to wait as we are now \"insolvent\"", QuestionAnswer="bankrupt ", Option1="", Option2="bankrupt ", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 13, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 14, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 15, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 16, Version="V1",QuestionImage="",Subject="English", Instructon="Choose the option that best conveys the meaning of the quote portion in the following sentence", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 17, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 18, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 19, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 20, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 21, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 22, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 23, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 24, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 25, Version="V1",QuestionImage="",Subject="English", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 26, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 27, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 28, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 29, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 30, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 31, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 32, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 33, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 34, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 35, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 36, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 37, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 38, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 39, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 40, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 41, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 42, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 43, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 44, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 45, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 46, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 47, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 48, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 49, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 50, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 51, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 52, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 53, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 54, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 55, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 56, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 57, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 58, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 59, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 60, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 61, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 62, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 67, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 68, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 68, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 69, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 70, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 71, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 72, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 73, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  },
            new TestExam {ID = 74, Version="V1",QuestionImage="",Subject="", Instructon="", Question= "", QuestionAnswer="", Option1="", Option2="", Option3="", Option4="", Option5=""  }
        };



























        IEnumerable<string> filteringQuery = from Subject in TestExam where Subject == Subject ;



        public string isQUery;
        static float score = 00;
        string diolugScore = score.ToString();
        public QUestionerePage()
        {
            this.InitializeComponent();
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
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

            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

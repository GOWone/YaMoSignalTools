using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YaMoSignalTools.Extensions.EmailService;
using MessageBox = System.Windows.MessageBox;
using Window = System.Windows.Window;

namespace YaMoSignalTools.Pages
{
    /// <summary>
    /// FeedBackPage.xaml 的交互逻辑
    /// </summary>
    public partial class FeedBackPage : Window
    {
        public FeedBackPage()
        {
            InitializeComponent();
        }


        private void FeedbackMove_LBDownEvent(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btn_CloseFeedback(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.feedbackPage = null;
        }

        private void btn_SubmitFeedback(object sender, MouseButtonEventArgs e)
        {
            string subject = null;
            string message = null;
            string message_first = null;
            string message_content = null;

            string UID = "YMC101231";
            foreach (var radioButton in FeedBackType.Children.OfType<RadioButton>())
            {
                if (radioButton.IsChecked == true)
                {
                    subject = radioButton.Content.ToString();
                    break; // Once found, no need to continue checking
                }
            }
            foreach (var radioButton in FeedBackModule.Children.OfType<RadioButton>())
            {
                if (radioButton.IsChecked == true)
                {
                    message_first = "反馈模块: " + radioButton.Content.ToString();
                    break; // Once found, no need to continue checking
                }
            }
            
            if(txt_content.Text != "")
            {
                message_content = txt_content.Text;
                message = "反馈类型: " + subject + "\n" + message_first + "\n" + "问题描述: " 
                    + message_content + "\n" + "反馈用户UID: " + UID;
                this.Close();
                MainWindow.feedbackPage = null;
                EmailService emailService = new EmailService();
                emailService.SendQQMail(subject, message);
                Growl.SuccessGlobal("[YaMo Studio] 感谢您的反馈!");
            }
            else
            {
                Growl.ErrorGlobal("请描述问题场景!");
            }
        }
    }
}

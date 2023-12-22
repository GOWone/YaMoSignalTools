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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YaMoSignalTools.Pages;

namespace YaMoSignalTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            IndexPage indexPage = new IndexPage();
            if (indexPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = indexPage
                };
            }
        }

        private void JunpToIndexPage_Event(object sender, MouseButtonEventArgs e)
        {
            IndexPage indexPage = new IndexPage();
            if (indexPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = indexPage
                };
            }
        }

        private void JunpToSignalMakerPage_Event(object sender, MouseButtonEventArgs e)
        {
            SignalMakerPage signalMaker = new SignalMakerPage();
            if (signalMaker != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = signalMaker
                };
            }
        }

        private void JunpToSignalTransferPage_Event(object sender, MouseButtonEventArgs e)
        {
            SignalTransferPage signalTransfer = new SignalTransferPage();
            if (signalTransfer != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = signalTransfer
                };
            }
        }

        private void JunpToSignalFilterPage_Event(object sender, MouseButtonEventArgs e)
        {
            SignalFilterPage signalFilter = new SignalFilterPage();
            if (signalFilter != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = signalFilter
                };
            }
        }

        private void JunpToCommonFuncPage_Event(object sender, MouseButtonEventArgs e)
        {
            CommonSignalOperatorPage commonSignalOperator = new CommonSignalOperatorPage();
            if (commonSignalOperator != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = commonSignalOperator
                };
            }
        }

        public static FeedBackPage feedbackPage = null;
        private void JumpToFeedBackPage_Event(object sender, RoutedEventArgs e)
        {
            if (feedbackPage == null)
            {
                feedbackPage = new FeedBackPage();
                feedbackPage.Show();
            }
            else
            {
                feedbackPage.Activate();
                feedbackPage.WindowState = WindowState.Normal;
            }
        }

        private void JumpToGithubPage_Event(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GOWone/YaMoSignalTools");
        }

        private void JumpToAboutUsPage_Event(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void JumpToSettingPage_Event(object sender, RoutedEventArgs e)
        {
            SystemSettingPage systemSettingPage = new SystemSettingPage();
            if (systemSettingPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = systemSettingPage
                };
            }
        }
    }
}

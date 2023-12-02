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
using YaMoSignalTools.Dialog;
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

        private void JumpToFeedBackPage_Event(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("./Dialog/FeedBackPage.xaml", UriKind.Relative);
            window.Show();
        }
    }
}

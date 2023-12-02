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

namespace YaMoSignalTools.Pages
{
    /// <summary>
    /// SignalMakerPage.xaml 的交互逻辑
    /// </summary>
    public partial class SignalMakerPage : Page
    {
        public SignalMakerPage()
        {
            InitializeComponent();
            Init();
            test1.ItemsSource = DataList; test2.ItemsSource = DataList; 
        }

        List<string> DataList;

        void Init()
        {
            DataList = new List<string>();
            DataList.Add("周期信号");
            DataList.Add("噪声信号");
            DataList.Add("混合信号");
        }
    }
}

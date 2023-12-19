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
    /// PeriodSignalParamPage.xaml 的交互逻辑
    /// </summary>
    public partial class PeriodSignalParamPage : Page
    {
        List<string> DataList = new List<string>() { 
            "正弦信号生成器", "余弦信号生成器", "三角波信号生成器", "方波信号生成器", "脉冲波信号生成器", "锯齿波信号生成器"};
        public PeriodSignalParamPage()
        {
            InitializeComponent();
            PeriodSigSelector.ItemsSource = DataList;
        }
    }
}

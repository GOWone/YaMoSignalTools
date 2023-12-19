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
    /// NoiseSignalParamPage.xaml 的交互逻辑
    /// </summary>
    public partial class NoiseSignalParamPage : Page
    {
        List<string> DataList = new List<string>() {
            "加性高斯白噪声(AWGN)信号生成器", " Perlin噪声信号生成器", "粉红(Pink)噪声信号生成器", "白噪声信号生成器", "红/布朗(Red)噪声信号生成器"};
        public NoiseSignalParamPage()
        {
            InitializeComponent();
            NoiseSigSelector.ItemsSource = DataList;
        }
    }
}

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
    /// MiscSignalParamPage.xaml 的交互逻辑
    /// </summary>
    public partial class MiscSignalParamPage : Page
    {
        List<string> DataList = new List<string>() {
            "WaveTable信号生成器", " Adsr信号生成器", "Ramp信号生成器", "Sinc信号生成器", "Chirp信号生成器", "PadSynth信号生成器", "KarplusStrong信号生成器", "KarplusStrongDrum信号生成器"};
        public MiscSignalParamPage()
        {
            InitializeComponent();
            MiscSigSelector.ItemsSource = DataList;
        }
    }
}

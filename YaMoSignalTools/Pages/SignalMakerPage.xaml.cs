using ScottPlot;
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

            // sample data
            double[] xs = DataGen.Consecutive(51);
            double[] sin = DataGen.Sin(51);
            double[] cos = DataGen.Cos(51);

            // plot the data
            WpfPlot1.Plot.AddScatter(xs, sin);
            WpfPlot2.Plot.AddScatter(xs, cos);
            WpfPlot3.Plot.AddScatter(xs, cos);

            // customize the axis labels
            WpfPlot1.Plot.XLabel("x");
            WpfPlot1.Plot.YLabel("y");

            WpfPlot2.Plot.XLabel("x");
            WpfPlot2.Plot.YLabel("y");

            WpfPlot3.Plot.XLabel("x");
            WpfPlot3.Plot.YLabel("y");

            WpfPlot1.Refresh();
            WpfPlot2.Refresh();
            WpfPlot3.Refresh();

            PeriodSignalParamPage periodSignalParamPage = new PeriodSignalParamPage();
            if (periodSignalParamPage != null)
            {
                SignalParamPresenter.Content = new Frame()
                {
                    Content = periodSignalParamPage
                };
            }
        }
    }
}

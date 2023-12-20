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
using YaMoSignalTools.Models;

namespace YaMoSignalTools.Pages
{
    /// <summary>
    /// PeriodSignalParamPage.xaml 的交互逻辑
    /// </summary>
    public partial class PeriodSignalParamPage : Page
    {
        List<string> DataList = new List<string>() { 
            "正弦信号生成器", "余弦信号生成器", "三角波信号生成器", "方波信号生成器", "脉冲波信号生成器", "锯齿波信号生成器"};
        List<SigMakerResInfo> sigmakerResInfos = new List<SigMakerResInfo>();
        public PeriodSignalParamPage()
        {
            InitializeComponent();
            InitInfo();
            ResInfoList.ItemsSource = sigmakerResInfos;
            PeriodSigSelector.ItemsSource = DataList;
        }

        private void InitInfo()
        {
            sigmakerResInfos.Clear();
            sigmakerResInfos.Add(new SigMakerResInfo() { Name = "信号类型", Flag = "->", Remark = "周期信号" });
            sigmakerResInfos.Add(new SigMakerResInfo() { Name = "信号生成器", Flag = "->", Remark = "正弦信号生成器" });
            sigmakerResInfos.Add(new SigMakerResInfo() { Name="信号长度", Flag = "->", Remark="1024"});
            sigmakerResInfos.Add(new SigMakerResInfo() { Name="信号频率(Hz)", Flag = "->", Remark ="100"});
            sigmakerResInfos.Add(new SigMakerResInfo() { Name="最大值", Flag = "->", Remark ="100"});
            sigmakerResInfos.Add(new SigMakerResInfo() { Name="最小值", Flag = "->", Remark ="-100"});
        }
    }
}

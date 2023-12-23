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
    /// IndexPage.xaml 的交互逻辑
    /// </summary>
    public partial class IndexPage : Page
    {
        List<IndexProjectInfoListItem> indexProjectInfoListItems = new List<IndexProjectInfoListItem>();
        public IndexPage()
        {
            InitializeComponent();
            InitInfo();
            ProjectInfoList.ItemsSource = indexProjectInfoListItems;
        }

        private void InitInfo()
        {
            indexProjectInfoListItems.Clear();
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 1,  ProjectName = "离散傅里叶变换", ProjectType = "信号变换器", UpdateTime = "2023-12-23 21:58"});
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 2,  ProjectName = "脉冲波信号生成", ProjectType = "信号生成器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 3,  ProjectName = "方波信号生成器", ProjectType = "信号生成器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 4, ProjectName = "FIR滤波器设计", ProjectType = "信号滤波器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 5, ProjectName = "IIR(切比雪夫II型)滤波器", ProjectType = "信号生成器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 6, ProjectName = "AWGN加性高斯白噪", ProjectType = "信号生成器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 7, ProjectName = "ADSR信封信号生成", ProjectType = "信号生成器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 8, ProjectName = "希尔伯特变换", ProjectType = "信号变换器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 9, ProjectName = "凯撒窗函数", ProjectType = "通用信号处理单元", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 10, ProjectName = "小波变换", ProjectType = "信号变换器", UpdateTime = "2023-12-23 21:58" });
            indexProjectInfoListItems.Add(new IndexProjectInfoListItem() { Order = 11, ProjectName = "IV 型离散余弦变换", ProjectType = "信号变换器", UpdateTime = "2023-12-23 21:58" });
        }
    }
}

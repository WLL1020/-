using System.Windows;
using ZXYWll0338;

namespace SurApp2024Wll0338
{
    /// <summary>
    /// AzimuthWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AzimuthWindow : Window
    {
        AzimuthWindowVM vm=new AzimuthWindowVM();
        public AzimuthWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Switch_Click(object sender, RoutedEventArgs e)
        {
            vm.Switch();
        }

        private void Cal_Click(object sender, RoutedEventArgs e)
        {
            vm.Calculate();
        }
    }
}

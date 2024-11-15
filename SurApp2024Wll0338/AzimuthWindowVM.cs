using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using ZXYWll0338;


namespace SurApp2024Wll0338
{
    public partial class AzimuthWindowVM : ObservableObject
    {
        /// <summary>
        /// 初始值
        /// </summary>
        public AzimuthWindowVM() 
        {
#if DEBUG
            A = new GPoint { Name = "GP01", X = 50342.464, Y = 3528.978 };
            B = new GPoint { Name = "GP02", X = 50289.874, Y = 3423.232 };
#endif
            A.PropertyChanged += OnPointPropertyChanged;
            B.PropertyChanged += OnPointPropertyChanged;
        }

        private void OnPointPropertyChanged(object? sender,System.ComponentModel.PropertyChangedEventArgs e)
        {
            CalculateCommand.NotifyCanExecuteChanged();
        }

        [ObservableProperty]
        private GPoint _A = new();

        [ObservableProperty]
        private GPoint _B = new();

        [ObservableProperty]
        private string? azName = "";

        [ObservableProperty]
        private string azValue = "";

        [ObservableProperty]
        private double dist;


        [RelayCommand]
        public void Switch()
        {
            (A, B) = (B, A);        //元组表达式          
        }

        [RelayCommand(CanExecute = nameof(CanCalculate))]
        //[RelayCommand]
        public void Calculate()
        {
            var ad = SurMath.Azimuth(A.X, B.X, A.Y, B.Y);
            AzValue = SurMath.RadianToString(ad.a);
            Dist = ad.d;

            AzName = $"{A.Name}-->{B.Name}坐标方位角";
        }
   
        /// <summary>
        /// 判断计算按键是否可用
        /// </summary>
        public bool CanCalculate => Math.Abs(A.X - B.X) >= 0.01 || Math.Abs(A.Y - B.Y) >= 0.01;
    }
}

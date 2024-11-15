using System.Windows.Input;
using ZXYWll0338;
using Point = ZXYWll0338.Point;


namespace SurApp2024Wll0338
{
    public class AzimuthWindowVM : NotificationObject
    {
        /// <summary>
        /// 初始值
        /// </summary>
        public AzimuthWindowVM() 
        {
#if DEBUG
            A = new Point { Name = "GP01", X = 50342.464, Y = 3528.978 };
            B = new Point { Name = "GP02", X = 50289.874, Y = 3423.232 };
#endif
        }


        private Point _A = new();
        public Point A
        {
            get => _A;
            set
            {
                if (_A != value)
                {
                    _A = value;
                    RaisePropertyChanged();
                }
            }
        }
        private Point _B = new();
        public Point B
        {
            get => _B;
            set
            {
                if (_B != value)
                {
                    _B = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string? azName = "";
        public string? AzName
        {
            get => azName;
            set
            {
                if (azName != value)
                {
                    azName = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string azValue = "";
        public string AzValue
        {
            get => azValue;
            set
            {
                if (azValue != value)
                {
                    azValue = value;
                    RaisePropertyChanged();
                }
            }
        }
        private double dist;
        public double Dist
        {
            get => dist;
            set
            {
                if (dist != value)
                {
                    dist = value;
                    RaisePropertyChanged();
                }
            }
        }


        public void Switch()
        {
            (A, B) = (B, A);        //元组表达式
            //Point p=new Point();
            //p = A;
            //A = B;
            //B = p;

        }
        public ICommand SwitchCommand => new RelayCommand((_)=> Switch());
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
        public ICommand CalCommand => new RelayCommand((_) => Calculate(), (_) => CanCalculate);

    }
}

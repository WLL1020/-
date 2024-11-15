using ZXYWll0338;
using Point = ZXYWll0338.Point;


namespace SurApp2024Wll0338
{
    public class AzimuthWindowVM : NotificationObject
    {
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

        public void Calculate()
        {
            var ad = SurMath.Azimuth(A.X, B.X, A.Y, B.Y);
            AzValue = SurMath.RadianToString(ad.a);
            Dist = ad.d;

            AzName = $"{A.Name}-->{B.Name}坐标方位角";
        }

    }
}

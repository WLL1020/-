using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXYWll0338;

namespace SurApp2024Wll0338
{
    public class AzimuthWindowVM : NotificationObject
    {
        private string? aName = "";
        public string? AName
        {
            get => aName;
            set
            {
                if(aName != value)
                {
                    aName = value;
                    RaisePropertyChanged();
                }
            } 
        }

        private double aX;
        public double AX
        {
            get => aX;
            set
            {
                if(aX != value)
                {
                    aX = value; 
                    RaisePropertyChanged();
                }
            }
        }
        private double aY;
        public double AY
        {
            get => aY;
            set
            {
                if (aY != value)
                {
                    aY = value;
                    RaisePropertyChanged();
                }
            }
        }

        //B点
        private string bName = "";
        public string BName
        {
            get => bName;
            set
            {
                if (bName != value)
                {
                    bName = value;
                    RaisePropertyChanged();
                }
            }
        }

        private double bX;
        public double BX
        {
            get => bX;
            set
            {
                if (bX != value)
                {
                    bX = value;
                    RaisePropertyChanged();
                }
            }
        }
        private double bY;
        public double BY
        {
            get => bY;
            set
            {
                if (bY != value)
                {
                    bY = value;
                    RaisePropertyChanged();
                }
            }
        }
        private string? azName="";
        public string? AzName
        {
            get =>azName;
            set
            {
                if(azName != value)
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
                if(azValue != value)
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
                if(dist != value)
                {
                    dist = value;
                    RaisePropertyChanged();
                }
            }
        }


        public void Switch()
        {
            string? tmp=AName;
            AName = BName; 
            BName = tmp;

            double t = AX;
            AX = BX;
            BX = t;

            t = AY;
            AY= BY;
            BY=t;
        }

        public void Calculate()
        {
            var ad = SurMath.Azimuth(AX, BX, AY, BY);
            AzValue = SurMath.RadianToString(ad.a);
            Dist = ad.d;

            AzName = $"{AName}-->{BName}坐标方位角";
        }

    }
}

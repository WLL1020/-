using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXYWll0338
{
    public static class PointExtension      //扩展Point类
    {
        public static (double a,double d)Azimuth(this Point ptA,Point ptB)        //this可以用前面那个调用函数
        {
            return SurMath.Azimuth(ptA.X,ptB.X,ptA.Y,ptB.Y);
        }

    }
}

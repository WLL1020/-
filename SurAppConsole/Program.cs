using ZXYWll0338;

namespace SurAppConsole
{
    internal class Program
    {
        ///// 调用TO0_2PI函数
        ///// </summary>
        ///// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    double R =( 5 * 2 +0.5) * Math.PI;
        //    double x = 0.5 * Math.PI;
        //    var r = SurMath.TO0_2PI(R);
        //    Console.WriteLine($"初始值为：{R}");
        //    Console.WriteLine($"预期的结果为：{x}");
        //    Console.WriteLine($"规划后结果为：{r}");
        //}

        ///// <summary>
        ///// 测试Azimuth函数
        ///// </summary>
        ///// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    double xA = 50342.464;
        //    double xB = 50289.874;
        //    double yA = 3423.232;
        //    double yB = 3528.978;
        //    var az = SurMath.Azimuth(xA, xB, yA, yB);

        //    Console.WriteLine($"计算的坐标方位角为{az.a}\n两点之间的距离为{az.d}");
        //}

        ///// <summary>
        ///// 调用RadianToDms函数
        ///// </summary>
        ///// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    var dms = SurMath.RadianToDms(1.93894073253047);

        //    Console.WriteLine($"预期中的结果为{111.053523452}");
        //    Console.WriteLine($"转换后的结果为{dms}");

        //}

        /// <summary>
        /// 调用函数DmsToRadian
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var rad = SurMath.DmsToRadian(111.053523452);

            Console.WriteLine($"预期结果为：1.93894073253047");
            Console.WriteLine($"计算结果为：{rad}");
        }
    }
}

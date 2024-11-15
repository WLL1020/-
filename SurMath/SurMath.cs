using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXYWll0338;

public static class SurMath
{
    public const double PI = Math.PI;
    public const double TWOPT = 2 * Math.PI;
    public const double TORAD = 180.0 / PI;
    public const double TODEG = PI / 180.0;
    public const double TOSECOND = 180.0 * 3600.0 / PI;

    /// <summary>
    /// 双精度型的度分秒角度提取函数 111 5 35.23452 ->111.053523452 ->
    /// </summary>
    /// <param name="dmsAngle"></param>
    /// <returns>度、分、秒元组值</returns>
    public static (int d, int m, double s) DmsToDms(double dmsAngle)
    {
        dmsAngle *= 10000;
        int iAngle = (int)dmsAngle;
        int d = iAngle / 10000;
        iAngle = iAngle - d * 10000;
        int m = iAngle / 100;
        double s = dmsAngle - d * 10000 - m * 100;

        return (d, m, s);
    }
    /// <summary>
    /// 度分秒转换为弧度
    /// </summary>
    /// <param name="dmsAngle"></param>
    /// <returns></returns>
    public static double DmsToRadian(double dmsAngle)
    {
        var dms = DmsToDms(dmsAngle);
        return ((dms.d + dms.m / 60.0 + dms.s / 3600.0) / TORAD);
    }

    /// <summary>
    /// 度分秒角度值1.02305 化度分秒字符串1°0.2′30.5″
    /// </summary>
    /// <param name="dmsAngle">度分秒角度：1.02305</param>
    /// <returns>度分秒字符串1°0.2′30.5″</returns>
    public static string DmsToString(double dmsAngle)
    {
        int f = dmsAngle >= 0 ? 1 : -1;        //用来判断选项，可以简化判断
        string ff = dmsAngle >= 0 ? "" : "-";      //用于输出结果前面的符号，因为直接写容易出错
        var dms = DmsToDms(dmsAngle);

        if (Math.Abs(dms.s) < 1e-10)       //判断秒，不是很清楚
            return $"{ff}{f * dms.d}°{f * dms.m:00}′{0:00.######}″";
        else
            return $"{ff}{f * dms.d}°{f * dms.m:00}′{f * dms.s:00.######}″";
    }
    /// <summary>
    /// 弧度化为基本的ddmmss方式
    /// </summary>
    /// <param name="radAngle"></param>
    /// <returns></returns>
    public static (int d, int m, double s) Radian2Dms(double radAngle)
    {
        radAngle *= TOSECOND;
        int angle = (int)radAngle;
        int d = angle / 3600;
        angle -= d * 3600;
        int m = angle / 60;
        double s = radAngle - d * 3600 - m * 60;
        return (d, m, s);
    }
    /// <summary>
    /// 弧度化度分秒角度
    /// </summary>
    /// <param name="radAngle">弧度角度值</param>
    /// <returns>度分秒角度1.2030</returns>
    public static double RadianToDms(double radAngle)
    {
        var dms = Radian2Dms(radAngle);
        return (dms.d + dms.m / 100.0 + dms.s / 10000.0);
    }
    /// <summary>
    /// 弧度化度分秒字符串
    /// </summary>
    /// <param name="radAngle">弧度角度值</param>
    /// <returns>度分秒字符串</returns>
    public static string RadianToString(double radAngle)
    {
        int f = radAngle >= 0 ? 1 : -1;
        string ff = radAngle >= 0 ? "" : "-";
        var dms = Radian2Dms(radAngle);
        if (Math.Abs(dms.s) < 1e-10)
            return $"{ff}{f * dms.d}°{f * dms.m:00}′{0:00.######}″";
        else
            return $"{ff}{f * dms.d}°{f * dms.m:00}′{f * dms.s:00.######}″";
    }

    /// <summary>
    /// 方位角计算 距离计算
    /// 参数为：xA,xB,yA,yB
    /// </summary>
    /// <param name="xA"></param>
    /// <param name="xB"></param>
    /// <param name="yA"></param>
    /// <param name="yB"></param>
    /// <returns>返回方位角和两点之间的距离</returns>
    public static (double a, double d) Azimuth(double xA, double xB, double yA, double yB)
    {
        double dy = yB - yA;
        double dx = xB - xA;
        double a = Math.Atan2(dy, dx) + (dy < 0 ? 1 : 0) * TWOPT;
        double d = Math.Sqrt(dx * dx + dy * dy);
        return (a, d);
    }

    /// <summary>
    /// 归化角度值至0-2Π
    /// </summary>
    /// <param name="rad"></param>
    /// <returns>0-2Π之间的角度</returns>
    public static double TO0_2PI(double rad)
    {
        int f = rad >= 0 ? 0 : 1;
        int n = (int)(rad / TWOPT);
        return rad - n * TWOPT + f * TWOPT;
    }

    public static object Azimuth(double? aX, double? bX, double? aY, double? bY)
    {
        throw new NotImplementedException();
    }
}

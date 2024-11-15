using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXYWll0338
{
    public class Point
    {
        private static int count = 0;

        private int id = 0;

        #region 参数设置

        public int Id
        {
            get; set;
        }
        public string? Name        //?表示Name可以为空
        {
            get; set;
        }
        public string? Code
        {
            get; set;
        }

        private double x;
        public double X
        {
            get => x;
            set => x = value;
        }
        private double y;
        public double Y
        {
            get => y;
            set => y = value;
        }
        private double z;
        public double Z
        {
            get => z;
            set => z = value;
        }
        #endregion  

        #region 构造函数初始化

        public Point()
        {
            Name = string.Empty;
            Code = string.Empty;
            x = 0;
            y = 0;
            z = 0;

            id = count++;       //点类数自增
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;

            id = count++;
        }

        public Point(string name,string code,double x, double y, double z)
        {
            this.Name = name;
            this.Code = code;
            this.x = x;
            this.y = y;
            this.z = z;

            id = count++;
        }

        #endregion

        public override string ToString()
        {
            return $"{Id},{Name},{Code},{X},{Y},{Z}";
        }
        }
    }


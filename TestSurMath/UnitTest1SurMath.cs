using ZXYWll0338;

namespace TestSurMath
{
    [TestClass]
    public class UnitTest1SurMath
    {
        [TestMethod]
        public void TestDmsToDms()
        {
            var dms = SurMath.DmsToDms(111.053523452);
            Assert.AreEqual(111, dms.d);
            Assert.AreEqual(5, dms.m);
            Assert.AreEqual(35.23452, dms.s, 1e-5);

            dms = SurMath.DmsToDms(-111.053523452);
            Assert.AreEqual(-111, dms.d);
            Assert.AreEqual(-5, dms.m);
            Assert.AreEqual(-35.23452, dms.s, 1e-5);

            dms = SurMath.DmsToDms(1.4000);
            Assert.AreEqual(1, dms.d);
            Assert.AreEqual(40, dms.m);
            Assert.AreEqual(0, dms.s, 1e-5);

            dms = SurMath.DmsToDms(-1.4000);
            Assert.AreEqual(-1, dms.d);
            Assert.AreEqual(-40, dms.m);
            Assert.AreEqual(0, dms.s, 1e-5);

            dms = SurMath.DmsToDms(1.40001);
            Assert.AreEqual(1, dms.d);
            Assert.AreEqual(40, dms.m);
            Assert.AreEqual(0.1, dms.s, 1e-5);


            dms = SurMath.DmsToDms(-1.40001);
            Assert.AreEqual(-1, dms.d);
            Assert.AreEqual(-40, dms.m);
            Assert.AreEqual(-0.1, dms.s, 1e-5);
        }

        [TestMethod]
        public void TestDmsToRadian()
        {
            var rad = SurMath.DmsToRadian(111.053523452);
            Assert.AreEqual(1.93894073253047, rad, 1e-13);

            rad = SurMath.DmsToRadian(111.053523452);
            Assert.AreEqual(1.93894073253047, rad, 1e-13);

            rad = SurMath.DmsToRadian(-111.053523452);
            Assert.AreEqual(-1.93894073253047, rad, 1e-13);

            rad = SurMath.DmsToRadian(1.4000);
            Assert.AreEqual(0.0290888208665722, rad, 1e-13);

            rad = SurMath.DmsToRadian(-1.4000);
            Assert.AreEqual(-0.0290888208665722, rad, 1e-13);

            rad = SurMath.DmsToRadian(1.40001);
            Assert.AreEqual(0.0290893056802533, rad, 1e-13);

            rad = SurMath.DmsToRadian(-1.40001);
            Assert.AreEqual(-0.0290893056802533, rad, 1e-13);

        }

        [TestMethod]
        public void TestDmsToString()
        {
            var str = SurMath.DmsToString(101.03201);
            Assert.AreEqual("101°03′20.1″", str);

            str = SurMath.DmsToString(-101.03201);
            Assert.AreEqual("-101°03′20.1″", str);

            str = SurMath.DmsToString(0.4001);
            Assert.AreEqual("0°40′01″", str);

            str = SurMath.DmsToString(-0.4001);
            Assert.AreEqual("-0°40′01″", str);

            str = SurMath.DmsToString(-1.4000);
            Assert.AreEqual("-1°40′00″", str);

            str = SurMath.DmsToString(1.4000);
            Assert.AreEqual("1°40′00″", str);

            str = SurMath.DmsToString(-1.4000);
            Assert.AreEqual("-1°40′00″", str);

        }

        [TestMethod]
        public void TestRadinToDms()
        {
            var dms = SurMath.RadianToDms(1.93894073253047);
            Assert.AreEqual(111.053523452, dms, 1e-10);

            dms = SurMath.RadianToDms(-1.93894073253047);
            Assert.AreEqual(-111.053523452, dms, 1e-10);

            dms = SurMath.RadianToDms(0.0290888208665722);
            Assert.AreEqual(1.4000, dms, 1e-13);

            dms = SurMath.RadianToDms(-0.0290888208665722);
            Assert.AreEqual(-1.4000, dms, 1e-13);

            dms = SurMath.RadianToDms(0.0290893056802533);
            Assert.AreEqual(1.40001, dms, 1e-13);

            dms = SurMath.RadianToDms(-0.0290893056802533);
            Assert.AreEqual(-1.40001, dms, 1e-13);
        }

        [TestMethod]
        public void TestRadianToString()
        {
            string dms = SurMath.RadianToString(0.0234165007975906);
            Assert.AreEqual<string>("1°20′30″", dms);

            dms = SurMath.RadianToString(-0.0234165007975906);
            Assert.AreEqual<string>("-1°20′30″", dms);

            dms = SurMath.RadianToString(0.02908882086657220);
            Assert.AreEqual<string>("1°40′00″", dms);

            dms = SurMath.RadianToString(-0.02908882086657220);
            Assert.AreEqual<string>("-1°40′00″", dms);

            dms = SurMath.RadianToString(0.02908930568025330);
            Assert.AreEqual<string>("1°40′00.1″", dms);

            dms = SurMath.RadianToString(-0.02908930568025330);
            Assert.AreEqual<string>("-1°40′00.1″", dms);

            dms = SurMath.RadianToString(0.69580806988502100);
            Assert.AreEqual<string>("39°52′00.71672″", dms);

            dms = SurMath.RadianToString(-0.69580806988502100);
            Assert.AreEqual<string>("-39°52′00.71672″", dms);

        }

        [TestMethod]
        public void TestAzimuth()
        {
            double xA = 50342.464;
            double xB = 50289.874;
            double yA = 3423.232;
            double yB = 3528.978;
            var az = SurMath.Azimuth(xA, xB, yA, yB);
            Assert.AreEqual<string>("116°26′32.102984″", SurMath.RadianToString(az.a));


            xA = 50289.874;
            xB = 50342.464;
            yA = 3528.978;
            yB = 3423.232;
            az = SurMath.Azimuth(xA, xB, yA, yB);
            Assert.AreEqual<string>("296°26′32.102984″", SurMath.RadianToString(az.a));


            xA = 50389.874;
            xB = 50342.464;
            yA = 3528.978;
            yB = 3423.232;
            az = SurMath.Azimuth(xA, xB, yA, yB);
            Assert.AreEqual<string>("245°51′05.295961″", SurMath.RadianToString(az.a));


            xA = 50342.464;
            xB = 50389.874;
            yA = 3423.232;
            yB = 3528.978;
            az = SurMath.Azimuth(xA, xB, yA, yB);
            Assert.AreEqual<string>("65°51′05.295961″", SurMath.RadianToString(az.a));

        }

        [TestMethod]
        public void TestTo0_2PI()
        {
            double R = 5 * 2.0 / 3 * Math.PI;
            var r = SurMath.TO0_2PI(R);
            Assert.AreEqual(4.0 / 3 * Math.PI, r, 1e-5);

            R = -5 * 2.0 / 3 * Math.PI;
            r = SurMath.TO0_2PI(R);
            Assert.AreEqual(2.0 / 3 * Math.PI, r, 1e-5);

            R = -5 * 2.0 * Math.PI;
            r = SurMath.TO0_2PI(R);
            Assert.AreEqual(2 * Math.PI, r, 1e-5);

            R = 5 * 2.0 * Math.PI;
            r = SurMath.TO0_2PI(R);
            Assert.AreEqual(0, r, 1e-5);

            R = -5 * 2.0 * Math.PI + 0.5 * Math.PI;
            r = SurMath.TO0_2PI(R);
            Assert.AreEqual(0.5 * Math.PI, r, 1e-5);

        }
        [TestMethod]
        public void TestPointAzimuth()
        {
            Point A = new Point(50342.464, 3423.232);
            Point B = new Point(50289.874, 3528.978);
            var az = A.Azimuth(B);
            Assert.AreEqual<string>("116°26′32.102984″", SurMath.RadianToString(az.a));

            B = new Point(50342.464, 3423.232);
            A = new Point(50289.874, 3528.978);
            az = A.Azimuth(B);//az = A.Azimuth(B);      //两种计算方法
            Assert.AreEqual<string>("296°26′32.102984″", SurMath.RadianToString(az.a));

            B = new Point(50342.464, 3423.232);
            A = new Point(50389.874, 3528.978);
            az = A.Azimuth(B);
            Assert.AreEqual<string>("245°51′05.295961″", SurMath.RadianToString(az.a));

            A = new Point(50342.464, 3423.232);
            B = new Point(50389.874, 3528.978);
            az = A.Azimuth(B);
            Assert.AreEqual<string>("65°51′05.295961″", SurMath.RadianToString(az.a));

        }

    }
}
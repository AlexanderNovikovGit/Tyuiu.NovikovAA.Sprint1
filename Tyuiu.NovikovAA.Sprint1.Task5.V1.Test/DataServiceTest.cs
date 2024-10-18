using Tyuiu.NovikovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1 = 0.0;
            double y1 = 0.0;
            double x2 = 3.0;
            double y2 = 4.0;
            DataService ds = new DataService();
            Assert.AreEqual(5, ds.DistanceBetweenDots(x1, y1, x2, y2));
        }
    }
}
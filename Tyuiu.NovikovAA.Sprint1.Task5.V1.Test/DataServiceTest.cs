using Tyuiu.NovikovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 0.5;
            double y = 3.0;
            DataService ds = new DataService();
            Assert.AreEqual(2, ds.Calculate(x, y));
        }
    }
}
using Tyuiu.NovikovAA.Sprint1.Task1.V6.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            Assert.AreEqual(0.5, ds.Calculate(x, y));
        }
    }
}
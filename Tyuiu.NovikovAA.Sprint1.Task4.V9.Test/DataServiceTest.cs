using Tyuiu.NovikovAA.Sprint1.Task4.V9.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2.71;
            Assert.AreEqual(-0.528, ds.Calculate(x, y));
        }
    }
}
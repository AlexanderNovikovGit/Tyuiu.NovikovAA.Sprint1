using Tyuiu.NovikovAA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.086, ds.Calculate(5, 5));
        }
    }
}
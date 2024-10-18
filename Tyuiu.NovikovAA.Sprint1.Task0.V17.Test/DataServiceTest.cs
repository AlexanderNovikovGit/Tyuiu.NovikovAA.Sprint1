using Tyuiu.NovikovAA.Sprint1.Task0.V17.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(5, ds.Calculate());
        }
    }
}
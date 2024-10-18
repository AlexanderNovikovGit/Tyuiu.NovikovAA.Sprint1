using Tyuiu.NovikovAA.Sprint1.Task2.V8.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(12, dataService.CalculatePerimetr(4, 2));
        }
    }
}
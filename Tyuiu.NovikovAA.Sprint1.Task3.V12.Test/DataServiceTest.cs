using Tyuiu.NovikovAA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(8, ds.TriangleArea(4, 4));
        }
    }
}
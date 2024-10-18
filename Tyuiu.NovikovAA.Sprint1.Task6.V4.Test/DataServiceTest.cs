using Tyuiu.NovikovAA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string world = "менн";
            Assert.AreEqual("менн", ds.CheckDoubleN(world));
        }
    }
}
using Tyuiu.ShaldinDA.Sprint2.Task3.V23.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            double result = ds.Calculate(2);
            Assert.AreEqual(36, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double result = ds.Calculate(0);
            Assert.AreEqual(-16, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double result = ds.Calculate(1);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double result = ds.Calculate(-30);
            Assert.AreEqual(-330.001, result);
        }
    }
}
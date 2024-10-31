using Tyuiu.ShaldinDA.Sprint2.Task2.V30.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
        }
    }
}
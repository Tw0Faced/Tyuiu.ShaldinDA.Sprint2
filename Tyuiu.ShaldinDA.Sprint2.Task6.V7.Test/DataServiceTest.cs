using Tyuiu.ShaldinDA.Sprint2.Task6.V7.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestJan()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindMonthName(1990, 0));
        }
        [TestMethod]
        public void TestFeb()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Февраль", ds.FindMonthName(1990, 1));
        }
        [TestMethod]
        public void TestDec()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Декабрь", ds.FindMonthName(1990, 11));
        }
        [TestMethod]
        public void TestNextYear()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindMonthName(1990, 12));
        }
    }
}
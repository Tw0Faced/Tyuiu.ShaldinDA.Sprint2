using Tyuiu.ShaldinDA.Sprint2.Task5.V1.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void Jan()
        {
            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
        }
        [TestMethod] 
        public void Feb()
        {
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InvalidMonth()
        {
            ds.FindMonthDaysCount(13);
        }
        
    }
}
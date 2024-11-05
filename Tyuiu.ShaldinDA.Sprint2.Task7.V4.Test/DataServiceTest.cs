using Tyuiu.ShaldinDA.Sprint2.Task7.V4.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task7.V4.Test
  
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestPointInsideShadedArea()
        {
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));
        }
        [TestMethod]
        public void TestPointOutsideShadedAre()
        {
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 1.1));
        }
        [TestMethod]
        public void TestPointOnBoundary()
        {
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 0));
        }


    }
}
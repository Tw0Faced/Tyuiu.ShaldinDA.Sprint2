using Tyuiu.ShaldinDA.Sprint2.Task0.V6.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 107;
            int y = 754;
            bool[] expectedResults = { true, true, true, false, true, false };
            bool[] actualResults = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(expectedResults, actualResults);  
        }
    }
}
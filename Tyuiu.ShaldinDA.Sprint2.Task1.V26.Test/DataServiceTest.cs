using Tyuiu.ShaldinDA.Sprint2.Task1.V26.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
             DataService ds = new DataService();
            int a = 654, b = 671, c = 874, d = 137;
            bool[] expected = { true, true, true, false, true, false };
            bool[] act = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(expected, act);
        }
    }
}
using Tyuiu.ShaldinDA.Sprint2.Task4.V21.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate1()
        {
            var calculator = new DataService();
            double x = 1;
            double y = 5;
            double result = calculator.Calculate(x,y);
            Assert.AreEqual(1024, result);
        }
        [TestMethod]
        public void TestCalculate2()
        {
            var calculator = new DataService();
            double x = 6;
            double y = 4.3;
            double result = calculator.Calculate(x, y);
            Assert.AreEqual(1.513, result);
        }
    }
}
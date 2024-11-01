using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaldinDA.Sprint2.Task4.V21.Lib
{
    public class DataService : ISprint2Task4V21
    {
        public double Calculate(double x, double y)
        {
            double z = x < y - 2
              ? Math.Pow((2 + ((x + 1) / x * x)), y)
              : (x * x + 10) / (y * y - Math.Sin(x) * Math.Sin(x) + 12);

            return Math.Round(z, 3);
        }
    }
}
    
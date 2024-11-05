using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaldinDA.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double radius = 1.0;
            bool inCircle = (x * x + y * y <= radius * radius) && (y >= 0);

            double smallRaius = 0.3;
            bool outSmallCircle = (x * x + y * y >= smallRaius * smallRaius) || (y <= 0);

            return inCircle && outSmallCircle;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaldinDA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a == 654) & (b < c);
            result[1] = (a != b) && (d <= 137);
            result[2] = (c > a) || (b == 671); 
            result[3] = (d >= c) ^ (a > 700); 
            result[4] = !(a > b) && (c >= 874);
            result[5] = (a < d) || (b > 900);

            return result;
        }
    }
}

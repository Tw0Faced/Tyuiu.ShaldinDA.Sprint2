using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaldinDA.Sprint2.Task0.V6.Lib
{
    public class DataService : ISprint2Task0V6
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool result1 = x == 107;        
            bool result2 = y != 107;        
            bool result3 = x < y;           
            bool result4 = x > 754;         
            bool result5 = x >= 107;        
            bool result6 = y <= 107;
            return new bool[] { result1, result2, result3, result4, result5, result6 };
        }
    }
}

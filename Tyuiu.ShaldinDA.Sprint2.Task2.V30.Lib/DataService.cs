using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaldinDA.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        private static readonly bool[,] shape = new bool[15, 15]
       {
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true,  true,  false },
            { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true  },
            { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true  },
            { false, true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true,  true,  true  },
            { false, true,  true,  true,  true,  true,  true,  false, false, false, false, false, true,  true,  true  },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, true,  true,  true,  true,  true,  true,  false, false },
            { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
            { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
            { false, false, false, false, false, false, false, false, false, true,  true,  true,  true,  false, false },
            { false, false, false, false, false, true,  true,  true,  true,  true,  true,  true,  false, false, false },
            { false, false, false, false, true,  true,  true,  true,  true,  true,  true,  false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }
       };
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15)
            {
                return false;
            }
            return shape[y - 1, x - 1];
        }
    }
}

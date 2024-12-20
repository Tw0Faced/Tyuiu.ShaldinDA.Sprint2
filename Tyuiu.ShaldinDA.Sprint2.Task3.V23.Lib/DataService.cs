﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaldinDA.Sprint2.Task3.V23.Lib
{
    public class DataService : ISprint2Task3V23
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 1)
            {
                y = Math.Pow((x * (x + 1)) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 17;
            }
            else if (x >= -27 && x < 2)
            {
                y = Math.Pow(3 + (1 / Math.Pow(x, 2)), x);
            }
            else
            {
                y = x + 10 * x - (1 / Math.Pow(x, 2));
            }
            return Math.Round(y, 3);
        }
    }
}

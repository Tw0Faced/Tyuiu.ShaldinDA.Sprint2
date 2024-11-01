using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaldinDA.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int monthNum = (n % 12) + 1;
            return monthNum switch
            {
                1 => "Январь",
                2 => "Февраль",
                3 => "Март",
                4 => "Апрель",
                5 => "Май",
                6 => "Июнь",
                7 => "Июль",
                8 => "Август",
                9 => "Сентябрь",
                10 => "Октябрь",
                11 => "Ноябрь",
                12 => "Декабрь",
                _ => throw new ArgumentOutOfRangeException(nameof(n), "Неверное значение")
            };
            
        }
    }
}

using Tyuiu.ShaldinDA.Sprint2.Task5.V1.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Оператор switch                                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                            *");
            Console.WriteLine("* Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая использует оператор switch вычисляет требуемо*");
            Console.WriteLine("*ое значение и возвращает результат. Условие: По данному номеру месяца, оп*");
            Console.WriteLine("*пределите количество дней в этом месяце.                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

           Console.WriteLine("Введите номер месяца (от 1 до 12): ");
            if (int.TryParse(Console.ReadLine(), out int month))
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                try
                {
                    int days = ds.FindMonthDaysCount(month);
                    Console.WriteLine($"Количество дней в месяце {month}: {days}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное числовое значение.");
            }
Console.ReadKey();
        }
    }
}
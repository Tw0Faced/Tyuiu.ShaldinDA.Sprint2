using Tyuiu.ShaldinDA.Sprint2.Task6.V7.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task6.V7
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
            Console.WriteLine("* Получение результата из switch                                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                            *");
            Console.WriteLine("* Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу с созданиеем MSTest, ClassLib, ConsoleApp, которая исп*");
            Console.WriteLine("*пользует сокращенную форму записи оператора switch вычисляет требуемое зн*");
            Console.WriteLine("*начение и возвращает результат. Условие: С начала 1990 года по некоторый *");
            Console.WriteLine("* день прошло n месяцев и 2 дня. Определить название месяца (январь, февра*");
            Console.WriteLine("*аль и т. п.) этого дня.                                                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начальный год: ");
            if (!int.TryParse(Console.ReadLine(), out int startYear))
            {
                Console.WriteLine("Пожалуйста, введите корректное значение года.");
                return;
            }
            Console.WriteLine("Введите количество месяцев с начала года: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                string monthName = ds.FindMonthName(startYear, n);
                Console.WriteLine($"Название месяца: {monthName}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
            }
           

            
            Console.ReadKey();
        }
    }
}
using Tyuiu.ShaldinDA.Sprint2.Task3.V23.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task3.V23
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
            Console.WriteLine("* Вложенные операторы if - else                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение функции Y с испо*");
            Console.WriteLine("*ользованием вложенных оператор if-else, где пользователь вводит значение *");
            Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков *");
            Console.WriteLine("* после запятой;                                                          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine("Введите значение X: ");
            
            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                double y = ds.Calculate(x);
                Console.WriteLine($"Значение Y: {y}");
            }
            else
            {
                Console.WriteLine("Неверное значение Y");
            }
            
            Console.ReadKey();
        }
    }
}
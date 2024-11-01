using Tyuiu.ShaldinDA.Sprint2.Task4.V21.Lib;
namespace Tyuiu.ShaldinDA.Sprint2.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #2 | Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тернарный оператор                                                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, котрая вычисляет требуемое значение с использованием *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит знвчение переменных X, Y с*");
            Console.WriteLine("*с клавиатуры, ответ округлите до 3 знаков после запятой                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());
           

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            double result = ds.Calculate(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
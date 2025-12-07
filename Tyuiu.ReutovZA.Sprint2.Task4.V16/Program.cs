using Tyuiu.ReutovZA.Sprint2.Task4.V16.Lib;

namespace Tyuiu.ReutovZA.Sprint2.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2  |  Выполнил: Реутов.З.А  |  ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание: #4                                                             *");
            Console.WriteLine("* Вариант: #16                                                            *");
            Console.WriteLine("* Выполнил: Реутов.З.А  | ПКТб-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение Z с помощью    *");
            Console.WriteLine("* тернарного оператора по заданным условиям.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write(" Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Значение Z = {z}");

            Console.ReadKey();
        }
    }
}
using Tyuiu.ReutovZA.Sprint2.Task3.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Реутов.З.А | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("*  Выполнил: Реутов.З.А | ПКТб-25-1                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
        Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
        Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение X:");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);

        Console.ReadKey();
    }
}
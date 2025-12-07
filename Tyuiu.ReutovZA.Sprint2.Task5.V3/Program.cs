using Tyuiu.ReutovZA.Sprint2.Task5.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Реутов.З.А  |  ПКТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Реутов.З.А  |  ПКТб-25-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.FindDayName(x);

Console.WriteLine(res);

Console.ReadKey();
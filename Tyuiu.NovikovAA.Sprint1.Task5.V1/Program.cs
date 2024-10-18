using Tyuiu.NovikovAA.Sprint1.Task5.V1.Lib;


Console.Title = "Спринт #1 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Double x1, y1, x2, y2;

Console.WriteLine("Введите x1");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x2");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));

Console.ReadKey();

using Tyuiu.NovikovAA.Sprint1.Task1.V6.Lib;


Console.Title = "Спринт #1 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #6                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле (x+y)/(3*y) и печатает его на экране.    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ( x + y ) / ( 3 * y )                                                   *");
Console.WriteLine("***************************************************************************");

Double x, y;

Console.WriteLine("Введите x");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();

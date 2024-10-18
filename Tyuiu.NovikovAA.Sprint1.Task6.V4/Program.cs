using Tyuiu.NovikovAA.Sprint1.Task6.V4.Lib;


Console.Title = "Спринт #1 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать               *");
Console.WriteLine("* все слова, содержащие удвоенное н (\"нн\").                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


string text = "";

Console.WriteLine("Введите текст");
text = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

String[] worlds = text.Split(' ');

DataService ds = new DataService();

foreach (string world in worlds)
{
    Console.WriteLine(ds.CheckDoubleN(world));
}


Console.ReadKey();

using Tyuiu.NovikovAA.Sprint1.Task7.V17.Lib;


Console.Title = "Спринт #1 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем. Ответ округлите   *");
Console.WriteLine("* до 3 знаков после запятой.                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* (1 + Sin(Sqrt(x * x + 1)) / Cos(12 * y - 4))                            *");
Console.WriteLine("***************************************************************************");

int x, y;

Console.WriteLine("Введите x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

Console.WriteLine(ds.Calculate(x, y));

Console.ReadKey();

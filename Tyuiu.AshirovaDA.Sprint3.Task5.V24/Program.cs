using System;
using Tyuiu.AshirovaDA.Sprint3.Task5.V24.Lib;

namespace Tyuiu.AshirovaDA.Sprint3.Task5.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Аширова Д.А. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить двойную сумму по формуле при X=2                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine($"* x = {x}");
            Console.WriteLine($"* Границы внешнего цикла: от {startValue1} до {stopValue1}");
            Console.WriteLine($"* Границы внутреннего цикла: от {startValue2} до {stopValue2}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"* Результат = {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
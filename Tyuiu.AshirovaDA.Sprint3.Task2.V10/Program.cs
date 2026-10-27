using Tyuiu.AshirovaDA.Sprint3.Task2.V10.Lib;

namespace Tyuiu.AshirovaDA.Sprint3.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Аширова Д.А. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при t=1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int t = 1;
            int startValue = 1;
            int stopValue = 13;

            Console.WriteLine($"* t = {t}");
            Console.WriteLine($"* Начало цикла = {startValue}");
            Console.WriteLine($"* Конец цикла = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetMultiplySeries(t, startValue, stopValue);
            Console.WriteLine($"* Произведение ряда = {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
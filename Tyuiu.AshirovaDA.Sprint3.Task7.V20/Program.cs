using Tyuiu.AshirovaDA.Sprint3.Task7.V20.Lib;

namespace Tyuiu.AshirovaDA.Sprint3.Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Аширова Д.А. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* F(x) = (sin(x)-2x)/(3x-1) + sin(x) - 3x + 2 на отрезке [-5; 5]          *");
            Console.WriteLine("* с шагом 1. При делении на ноль вернуть 0.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"* Диапазон: от {startValue} до {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Выводим таблицу значений
            Console.WriteLine("  X   |   F(X)  ");
            Console.WriteLine("----------------");
            for (int i = 0; i < res.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"{x,4}  | {res[i],7}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
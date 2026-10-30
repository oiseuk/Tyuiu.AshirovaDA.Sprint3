using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirovaDA.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V3
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            // Перебираем каждое число на заданном отрезке
            for (int i = startValue; i <= stopValue; i++)
            {
                // Ищем делители для текущего числа i
                for (int d = 1; d <= i; d++)
                {
                    // Если d является делителем (делится без остатка) И больше 8
                    if (i % d == 0 && d > 8)
                    {
                        sum += d; // Добавляем его к общей сумме
                    }
                }
            }

            return sum;
        }
    }
}
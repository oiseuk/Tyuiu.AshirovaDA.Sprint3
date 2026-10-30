using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirovaDA.Sprint3.Task5.V24.Lib
{
    public class DataService : ISprint3Task5V24
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            // Внешний цикл (по i)
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл (по k)
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Вычисляем элемент: (x^k + 2) * sin(k)
                    double term = (Math.Pow(x, k) + 2) * Math.Sin(k);

                    // Добавляем к общей сумме
                    totalSum += term;
                }
            }

            // Округляем до 3 знаков для системы проверки
            return Math.Round(totalSum, 3);
        }
    }
}
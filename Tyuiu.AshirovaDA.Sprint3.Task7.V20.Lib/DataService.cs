using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirovaDA.Sprint3.Task7.V20.Lib
{
    public class DataService : ISprint3Task7V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Вычисляем количество точек (шаг 1)
            int count = stopValue - startValue + 1;
            double[] result = new double[count];

            int index = 0;

            // Цикл от -5 до 5 включительно
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                // Проверка деления на ноль (3x - 1 == 0)
                if (3 * x - 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    // Сама формула
                    y = (Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2;
                }

                // Округляем до 2 знаков и записываем в массив
                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
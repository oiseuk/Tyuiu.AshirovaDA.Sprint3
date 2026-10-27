using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirovaDA.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            // Начальное значение произведения всегда 1
            double p = 1.0;

            // Инициализируем счетчик k
            int k = startValue;

            // Цикл do-while: сначала выполняем блок, потом проверяем условие
            do
            {
                // Вычисляем текущий множитель: t^k + 1/(k+1)
                // value — это t, k — текущий шаг
                double term = Math.Pow(value, k) + (1.0 / (k + 1));

                // Накапливаем произведение
                p *= term;

                // Увеличиваем счетчик
                k++;
            }
            while (k <= stopValue);

            // Округляем до 3 знаков, чтобы избежать ошибки "Не сошлись ответы"
            return Math.Round(p, 3);
        }
    }
}
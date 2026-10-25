using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirovaDA.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            // Начальное значение произведения всегда 1
            double p = 1.0;

            // Инициализируем счетчик k нижней границей
            int k = startValue;

            // Цикл while работает, пока k не превысит верхнюю границу
            while (k <= stopValue)
            {
                // Считаем основание степени: 2 / cos(x)
                double baseValue = 2.0 / Math.Cos(value);

                // Накапливаем произведение: p = p * (baseValue ^ k)
                p *= Math.Pow(baseValue, k);

                // Увеличиваем счетчик
                k++;
            }

            // Округляем результат до 3 знаков, чтобы соответствовать ожиданиям системы
            return Math.Round(p, 3);
        }
    }
}
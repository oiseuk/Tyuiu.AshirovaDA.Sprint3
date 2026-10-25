using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirovaDA.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1.0;

            int k = startValue;

            while (k <= stopValue)
            {
                double baseValue = 2.0 / Math.Cos(value);
                p *= Math.Pow(baseValue, k);
                k++;
            }

            return p;
        }
    }
}
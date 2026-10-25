using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirovaDA.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                
                sum += (Math.Pow(value, 2) * i) + 1;
            }

            return sum;
        }
    }
}
using Tyuiu.AshirovaDA.Sprint3.Task4.V30.Lib;

namespace Tyuiu.AshirovaDA.Sprint3.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            // Правильное ожидаемое значение — 1.924
            double wait = 1.924;

            Assert.AreEqual(wait, res);
        }
    }
}
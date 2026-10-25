using Tyuiu.AshirovaDA.Sprint3.Task1.V17.Lib;

namespace Tyuiu.AshirovaDA.Sprint3.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = Math.Pow(2.0 / Math.Cos(1), 10);

            Assert.AreEqual(wait, res, 0.0001);
        }
    }
}
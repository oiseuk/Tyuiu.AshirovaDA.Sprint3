using Tyuiu.AshirovaDA.Sprint3.Task2.V10.Lib;

namespace Tyuiu.AshirovaDA.Sprint3.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int t = 1;
            int startValue = 1;
            int stopValue = 13;

            double res = ds.GetMultiplySeries(t, startValue, stopValue);

 
            double wait = 7.5;

            Assert.AreEqual(wait, res);
        }
    }
}
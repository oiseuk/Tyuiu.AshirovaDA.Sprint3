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

            // Теперь ожидаем ровно то, что требует система проверки (округленное до 3 знаков)
            double wait = 482982.891;

            // Сравниваем без погрешности, так как числа уже округлены
            Assert.AreEqual(wait, res);
        }
    }
}
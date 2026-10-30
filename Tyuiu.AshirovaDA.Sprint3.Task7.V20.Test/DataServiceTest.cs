using Tyuiu.AshirovaDA.Sprint3.Task7.V20.Lib;

namespace Tyuiu.AshirovaDA.Sprint3.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Проверяем, что длина массива 11
            Assert.AreEqual(11, res.Length);

            // Посмотрим, чему равно при x = 0 (индекс 5)
            // F(0) = (sin(0) - 0) / (0 - 1) + sin(0) - 0 + 2 = 0 + 0 + 2 = 2
            double expectedAtZero = 2.0;
            Assert.AreEqual(expectedAtZero, res[5]);
        }
    }
}
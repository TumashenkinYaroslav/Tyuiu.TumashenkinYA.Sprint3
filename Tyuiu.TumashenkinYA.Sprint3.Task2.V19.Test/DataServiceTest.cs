using Tyuiu.TumashenkinYA.Sprint3.Task2.V19.Lib;
namespace Tyuiu.TumashenkinYA.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 2;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = -0.709;
            Assert.AreEqual(res, wait);
        }
    }
}

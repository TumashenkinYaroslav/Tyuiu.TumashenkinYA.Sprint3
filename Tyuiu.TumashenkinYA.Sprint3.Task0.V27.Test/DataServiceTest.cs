using Tyuiu.TumashenkinYA.Sprint3.Task0.V27.Lib;
namespace Tyuiu.TumashenkinYA.Sprint3.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(16, ds.GetSumSeries(1, 1, 1));
        }
    }
}
﻿using Tyuiu.TumashenkinYA.Sprint3.Task5.V16.Lib;
namespace Tyuiu.TumashenkinYA.Sprint3.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            Assert.AreEqual(745.748, ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}

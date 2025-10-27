﻿using Tyuiu.TumashenkinYA.Sprint3.Task4.V7.Lib;
namespace Tyuiu.TumashenkinYA.Sprint3.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 1231.499;

            Assert.AreEqual(wait, res);
        }
    }
}

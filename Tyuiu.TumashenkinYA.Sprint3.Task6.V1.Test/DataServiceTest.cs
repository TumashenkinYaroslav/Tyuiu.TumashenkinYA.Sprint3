﻿using Tyuiu.TumashenkinYA.Sprint3.Task6.V1.Lib;
namespace Tyuiu.TumashenkinYA.Sprint3.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 151;
            Assert.AreEqual(wait, res);
        }
    }
}

﻿using Tyuiu.AndreevIA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.AndreevIA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(number);
            Assert.AreEqual(15, res);

        }

        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5};
            var res = DataService.SubtractionArray(number);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(number);
            Assert.AreEqual(120, res);
        }
    }
}

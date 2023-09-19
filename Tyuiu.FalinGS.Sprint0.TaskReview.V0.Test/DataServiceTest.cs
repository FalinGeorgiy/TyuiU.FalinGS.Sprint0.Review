using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FalinGS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.FalinGS.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int First = 5;
            int Second = 10;
            int Third = 20;

            int res = DataService.Calc(First, Second, Third);
            Assert.AreEqual(200, res);
        }
    }
}

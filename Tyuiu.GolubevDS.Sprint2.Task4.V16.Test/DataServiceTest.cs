using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GolubevDS.Sprint2.Task4.V16.Lib;
namespace Tyuiu.GolubevDS.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VolidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 1.01;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void VolidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 0.99;
            Assert.AreEqual(wait, res);
        }
    }
}

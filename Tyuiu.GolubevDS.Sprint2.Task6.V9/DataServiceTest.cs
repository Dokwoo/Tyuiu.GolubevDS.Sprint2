using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GolubevDS.Sprint2.Task6.V9.Lib;
namespace Tyuiu.GolubevDS.Sprint2.Task6.V9
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шесть пики", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Семь трефы", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("Восемь бубны", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("Девять червы", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("Десять пики", ds.FindCardNameAndValue(1, 10));
            Assert.AreEqual("Дама трефы", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("Дама бубны", ds.FindCardNameAndValue(3, 12));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint2.Task5.V10.Lib;
namespace Tyuiu.SabarovDA.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 21, m = 11, g = 1997;
            int wait = 20111997;
            int res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}

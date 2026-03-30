using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint3.Task1.V20.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 16;

            double res = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(173.9812, res, 4);
        }
    }
}
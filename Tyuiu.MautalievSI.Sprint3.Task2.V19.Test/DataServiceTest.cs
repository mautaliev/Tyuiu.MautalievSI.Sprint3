using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint3.Task2.V19.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(-0.168, res);
        }
    }
}
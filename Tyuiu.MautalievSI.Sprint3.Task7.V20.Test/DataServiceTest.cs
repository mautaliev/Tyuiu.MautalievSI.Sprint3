using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint3.Task7.V20.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { 19.84, 15.78, 11.66, 7.41, 2.74, 0.00, 0.18, -1.07, -2.49, -4.09, -5.91 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
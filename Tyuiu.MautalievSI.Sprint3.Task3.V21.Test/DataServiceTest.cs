using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint3.Task3.V21.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "f3g5ht g4j 34kg4";
            char item = 'e';

            string res = ds.ReplaceNumOnChar(value, item);

            Assert.AreEqual("fegeht gej eekge", res);
        }
    }
}
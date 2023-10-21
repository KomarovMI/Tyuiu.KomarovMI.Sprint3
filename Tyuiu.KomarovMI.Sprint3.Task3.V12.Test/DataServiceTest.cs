using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint3.Task3.V12.Lib;

namespace Tyuiu.KomarovMI.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string value = "bkkrk ckkkcs ksr";
            char chr = 'k';
            int res = ds.GetMaxCharCount(value, chr);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}

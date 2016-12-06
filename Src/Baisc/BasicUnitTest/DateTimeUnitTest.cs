using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicUnitTest
{
    [TestClass]
    public class DateTimeUnitTest
    {
        [TestMethod]
        public void FormatUnitTest()
        {
            DateTime dt = new DateTime(2014, 6, 23, 8, 30, 1);
            
            Assert.AreEqual("2016-06-23 08:30:01", dt.ToString("t"));
        }
    }
}

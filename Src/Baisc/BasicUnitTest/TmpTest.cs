using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicUnitTest
{
    [TestClass]
    public class TmpTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual("10", "10");
        }
    }
}

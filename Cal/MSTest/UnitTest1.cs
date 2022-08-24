using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cal;


namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            Calculation c = new Calculation();
            Assert.AreEqual(10, c.sum(5, 5));
        }
        [TestMethod]
        /*[Ignore("Skip")]*/
        public void sub()
        {
            Calculation c = new Calculation();
            Assert.AreEqual(10, c.sub(15, 5));
        }

    }



}

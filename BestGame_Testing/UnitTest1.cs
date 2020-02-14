using System;
using BestGame_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGame_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrder AnAddress = new clsOrder();
            Assert.IsNotNull(AnAddress);
        }
    }
}

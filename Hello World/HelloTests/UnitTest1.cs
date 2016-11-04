using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hello_World.TestLogic oLogic = new Hello_World.TestLogic();


            Assert.AreEqual(oLogic.go(0), 0);
            Assert.AreEqual(oLogic.go(1), 0);
            Assert.AreEqual(oLogic.go(2), 1);


        }
    }
}

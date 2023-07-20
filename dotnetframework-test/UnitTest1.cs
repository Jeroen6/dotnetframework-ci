using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;

namespace dotnetframework_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod2()
        {
            throw new NotImplementedException("Please create a test first.");
        }
    }
}

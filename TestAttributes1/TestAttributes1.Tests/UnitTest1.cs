using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Ignore]
        [Owner("Ömer Faruk")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Uptaded by","Halil")]
        
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod,Timeout(1000)]
        [Owner("Ömer Faruk")]
        [TestCategory("Tester")]
        [Priority(1)]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod,Timeout(TestTimeout.Infinite)]
        [Owner("Ömer Faruk")]
        [TestCategory("Developer")]
        [TestCategory("Tester")]
        [TestCategory("Demo")]
        [Priority(2)]


        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod,Description("This is a description.")]
        [Owner("Halil")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod]
        [Owner("Halil")]
        [TestCategory("Developer")]
        [Priority(1)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}

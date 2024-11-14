using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestContextDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        
        
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("--Test Initialize--\n");
            TestContext.WriteLine("Test Name: {0}",TestContext.TestName);
            TestContext.WriteLine("Test Result: {0}",TestContext.CurrentTestOutcome);
            TestContext.Properties["info"] = "this is extra info";
            
            Assert.AreEqual(1,1);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("\n--Test Cleanup--\n");
            TestContext.WriteLine("Test Name: {0}",TestContext.TestName);
            TestContext.WriteLine("Test Result: {0}",TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test İnfo: {0}", TestContext.Properties["info"]);
            
            Assert.AreEqual(1,1);
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("\n--Test Method 1--\n");
            TestContext.WriteLine("Test Name: {0}",TestContext.TestName);
            TestContext.WriteLine("Test Result: {0}",TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Class: {0}",TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test İnfo: {0}", TestContext.Properties["info"]);

            Assert.AreEqual(1,1);
        }
    }
}

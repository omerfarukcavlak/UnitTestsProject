using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace StringAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Test dünyasından merhaba", "yas");
        }
        
        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches("Test dünyasından merhaba", new Regex(@"[a-zA-Z]") );
            StringAssert.DoesNotMatch("Test dünyasından merhaba", new Regex(@"[0-9]") );
        }
        
        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.Contains("Test dünyasından merhaba", "Test");
        }
        
        [TestMethod]
        public void EndsWithtTest()
        {
            StringAssert.Contains("Test dünyasından merhaba", "merhaba");
        }
    }
}

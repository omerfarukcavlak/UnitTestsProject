using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Asserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double enteredValue = 16;
            const double expected = 4;
            double actualValue = Math.Sqrt(enteredValue);

            Assert.AreEqual(expected, actualValue, "The square root of {0} should be {1}", enteredValue, expected);

        }


        [TestMethod]
        public void TestMethod2()
        {
            double expected = 3.1622;
            double delta = 0.0001;
            double actual = Math.Sqrt(10);
            /*
             if(|actual - expected|<= delta)
            {
            Assert.AreEqual(expected, actual, delta) =true;
            }

            else
            {
            Assert.AreEqual(expected, actual, delta) =false;
            }
             */
            Assert.AreEqual(expected, actual,delta);

        }


        [TestMethod]
        public void TestMethod3()
        {
            string expected = "MERHABA";
            string actual = "Merhaba";

            Assert.AreEqual(expected, actual,true);

        }


        [TestMethod]
        public void TestMethod4()
        {
            const double notExpected = 0;
            var actual = Math.Pow(5, 0);

            Assert.AreNotEqual(notExpected, actual);

        }
    }
}

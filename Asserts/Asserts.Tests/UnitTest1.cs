using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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
            Assert.AreEqual(expected, actual, delta);

        }


        [TestMethod]
        public void TestMethod3()
        {
            string expected = "MERHABA";
            string actual = "Merhaba";

            Assert.AreEqual(expected, actual, true);

        }


        [TestMethod]
        public void TestMethod4()
        {
            const double notExpected = 0;
            var actual = Math.Pow(5, 0);

            Assert.AreNotEqual(notExpected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            var numbers = new byte[] { 1, 2, 3 };
            var otherNumbers = numbers;
            numbers[0] = 4;

            Assert.AreSame(numbers, otherNumbers);


        }

        [TestMethod]
        public void TestMethod6()
        {
            int a = 10;
            int b = a;

            Assert.AreEqual(a, b, "AreEqual Failed");
            Assert.AreNotSame(a, b, "AreSame Failed");

        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("This test is not sufficient");

        }

        [TestMethod]
        public void TestMethod8()
        {
            var sayi = 5m;

            Assert.IsInstanceOfType(sayi, typeof(decimal));
            Assert.IsNotInstanceOfType(sayi, typeof(int));

        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);


        }

        [TestMethod]
        public void TestMethod10()
        {
            List<string> names = new List<string> { "Ömer Faruk", "Halil", "Recep" };
            var firstNameStartsWithA = names.FirstOrDefault(t => t.StartsWith("A"));
            var firstNameStartsWithH = names.FirstOrDefault(t => t.StartsWith("H"));


            Assert.IsNull(firstNameStartsWithA, "IsNull failed!");
            Assert.IsNotNull(firstNameStartsWithH, "IsNotNull failed!");

        }

        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                var number = 5;
                int result = number / 0;
            }
            catch (DivideByZeroException)
            {
                Assert.Fail("Test failed!");
            }

        }
    }
}

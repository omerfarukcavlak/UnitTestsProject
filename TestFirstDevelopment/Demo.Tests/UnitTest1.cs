using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var olcumler = new List<Olcum>()
            {
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                }
            };
            var gruplayici = new Gruplayici(1);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(1, gruplar.Count);
        }
    }
}

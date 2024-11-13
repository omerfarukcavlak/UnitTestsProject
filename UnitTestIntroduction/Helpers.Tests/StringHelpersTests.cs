using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{

    [TestClass]
    public class StringHelpersTests
    {
        [TestMethod]
        public void RemoveExtraSpacesFromStartAndEnd()
        {
            var expression = "   Ömer Faruk CAVLAK     ";
            var expected = "Ömer Faruk CAVLAK";

            var actual = StringHelper.RemoveExtraSpaces(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveExcessiveSpacesInString()
        {
            var expression = "Ömer         Faruk                                 CAVLAK";
            var expected = "Ömer Faruk CAVLAK";

            var actual = StringHelper.RemoveExtraSpaces(expression);

            Assert.AreEqual(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Users.xml", "User", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var manager = new UserManager();

            var name = TestContext.DataRow["name"].ToString();
            var phone = TestContext.DataRow["phone"].ToString();
            var mail = TestContext.DataRow["mail"].ToString();

            var result = manager.AddUser(name, phone, mail);

            Assert.IsTrue(result);
        }
    }
}

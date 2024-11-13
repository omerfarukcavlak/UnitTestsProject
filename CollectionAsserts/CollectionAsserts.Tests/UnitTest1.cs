using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _users;

        [TestInitialize]
        public void CreateData()
        {
            _users = new List<string>();

            _users.Add("Ömer Faruk");
            _users.Add("Halil");
            _users.Add("Recep");
        }

        [TestMethod]
        public void ElementsAndOrderMustBeTheSame()
        {
            List<string> newUsers = new List<string>();


            newUsers.Add("Ömer Faruk");
            newUsers.Add("Halil");
            newUsers.Add("Recep");

            CollectionAssert.AreEqual(newUsers, _users);
        }

        [TestMethod]
        public void ElementsMayBeTheSameButOrderMayVary()
        {
            List<string> newUsers = new List<string>();

            
            newUsers.Add("Halil");
            newUsers.Add("Ömer Faruk");
            newUsers.Add("Recep");

            CollectionAssert.AreEquivalent(newUsers, _users);
        }



        [TestMethod]
        public void ElementsOrOrderMustNotBeTheSame()
        {
            List<string> newUsers = new List<string>();

            newUsers.Add("Halil");
            newUsers.Add("Ömer Faruk");
            newUsers.Add("Recep");

            CollectionAssert.AreNotEqual(newUsers, _users);
        }


        [TestMethod]
        public void ElementsMustBeDifferent()
        {
            List<string> newUsers = new List<string>();


            newUsers.Add("Ömer Faruk");
            newUsers.Add("Halil");
            newUsers.Add("Recep");
            newUsers.Add("Timur Kağan");

            CollectionAssert.AreNotEquivalent(newUsers, _users);
        }


        [TestMethod]
        public void UsersMustNotHaveNullValue()
        {
            CollectionAssert.AllItemsAreNotNull(_users);
        }


        [TestMethod]
        public void UsersMustBeUnique()
        {
            CollectionAssert.AllItemsAreUnique(_users);
        }


        [TestMethod]
        public void AllElementsMustBeOfTheSameType()
        {
            ArrayList list = new ArrayList
            {
                "Ömer Faruk","Halil","Recep"
            };
            CollectionAssert.AllItemsAreInstancesOfType(list, typeof(string));
        }


        [TestMethod]
        public void IsSubsetOfTest()
        {
            List<string> newUsers = new List<string>() { "Ömer Faruk","Halil"};
            List<string> oldUsers = new List<string>() { "Ömer Faruk","Timur Kağan"};

            CollectionAssert.IsSubsetOf(newUsers, _users);
            CollectionAssert.IsNotSubsetOf(oldUsers, _users);
        }


        [TestMethod]
        public void ContainTest()
        {
            CollectionAssert.Contains( _users,"Ömer Faruk");
            CollectionAssert.DoesNotContain(_users, "Timur Kağan");
        }
    }
}

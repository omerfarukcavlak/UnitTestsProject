using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private static CartItem _cartItem;
        private static CartManager _cartManager;


        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 25000
                },
                Quantity = 1

            };
            _cartManager.Add(_cartItem);
        }

        [ClassCleanup]
        public static void TestCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void ShouldIncreaseTotalProductCountAndDistinctItemCount_WhenSecondProductIsAdded()
        {
            int totalQuantity = _cartManager.TotalQuantity;
            int totalItems = _cartManager.TotalItems;

            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    UnitPrice = 10
                },
                Quantity = 1
            });

            Assert.AreEqual(totalQuantity + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(totalItems + 1, _cartManager.TotalItems);
        }


        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        [ExpectedException(typeof(Exception),AllowDerivedTypes = true)]
        public void ShouldThrowError_WhenSameProductIsAddedToCartTwice()
        {
            _cartManager.Add(_cartItem);
        }
    }
}

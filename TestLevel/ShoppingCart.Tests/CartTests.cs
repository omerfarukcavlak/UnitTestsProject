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
        private CartItem _cartItem;
        private CartManager _cartManager;


        [TestInitialize]
        public void TestInitialize()
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

        [TestCleanup]
        public void TestCleanup()
        {
            _cartManager.Clear();
        }




        [TestMethod]
        public void ShouldBeAbleToAddProductToCart()
        {
            const int expected = 1;

            var totalItems = _cartManager.TotalItems;

            Assert.AreEqual(expected, totalItems);

        }


        [TestMethod]
        public void ShouldBeAbleToRemoveProductFromCart()
        {
            var numberOfItemsInCart = _cartManager.TotalItems;
            _cartManager.Remove(1);
            var remainingItemsInCart = _cartManager.TotalItems;

            Assert.AreEqual(numberOfItemsInCart - 1, remainingItemsInCart);
        }

        [TestMethod]
        public void ShouldBeAbleToClearTheCart()
        {
            _cartManager.Clear();

            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);
        }
    }
}

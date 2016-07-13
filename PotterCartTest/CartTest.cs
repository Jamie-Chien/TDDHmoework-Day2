using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterCart;

namespace PotterCartTest
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void BuyFirstPriceShouldBe100()
        {
            //arrange
            var cart = new Cart();

            //act
            cart.Add(new Book { Volume = Volume.First });

            //assert
            int expected = 100;
            Assert.AreEqual(expected, cart.GetPrice());
        }
    }
}
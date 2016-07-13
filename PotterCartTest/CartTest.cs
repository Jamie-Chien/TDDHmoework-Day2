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

        [TestMethod]
        public void BuyFirstAndSecondPriceShouldBe190()
        {
            //arrange
            var cart = new Cart();

            //act
            cart.Add(new Book { Volume = Volume.First });
            cart.Add(new Book { Volume = Volume.Second });

            //assert
            int expected = 190;
            Assert.AreEqual(expected, cart.GetPrice());
        }

        [TestMethod]
        public void BuyFirstToThirdPriceShouldBe270()
        {
            //arrange
            var cart = new Cart();

            //act
            cart.Add(new Book { Volume = Volume.First });
            cart.Add(new Book { Volume = Volume.Second });
            cart.Add(new Book { Volume = Volume.Third });


            //assert
            int expected = 270;
            Assert.AreEqual(expected, cart.GetPrice());
        }

        [TestMethod]
        public void BuyFirstToFourthPriceShouldBe320()
        {
            //arrange
            var cart = new Cart();

            //act
            cart.Add(new Book { Volume = Volume.First });
            cart.Add(new Book { Volume = Volume.Second });
            cart.Add(new Book { Volume = Volume.Third });
            cart.Add(new Book { Volume = Volume.Fourth });

            //assert
            int expected = 320;
            Assert.AreEqual(expected, cart.GetPrice());
        }

        [TestMethod]
        public void BuyFirstToFifthPriceShouldBe375()
        {
            //arrange
            var cart = new Cart();

            //act
            cart.Add(new Book { Volume = Volume.First });
            cart.Add(new Book { Volume = Volume.Second });
            cart.Add(new Book { Volume = Volume.Third });
            cart.Add(new Book { Volume = Volume.Fourth });
            cart.Add(new Book { Volume = Volume.Fifth });

            //assert
            int expected = 375;
            Assert.AreEqual(expected, cart.GetPrice());
        }

        [TestMethod]
        public void BuyFirst1Seond1Third2PriceShouldBe370()
        {
            //arrange
            var cart = new Cart();

            //act
            cart.Add(new Book { Volume = Volume.First });
            cart.Add(new Book { Volume = Volume.Second });
            cart.Add(new Book { Volume = Volume.Third });
            cart.Add(new Book { Volume = Volume.Third });

            //assert
            int expected = 370;
            Assert.AreEqual(expected, cart.GetPrice());
        }

        [TestMethod]
        public void BuyFirst1Second2Third2PriceShould460()
        {
            //arrange
            var cart = new Cart();

            //act
            cart.Add(new Book { Volume = Volume.First });
            cart.Add(new Book { Volume = Volume.Second });
            cart.Add(new Book { Volume = Volume.Second });
            cart.Add(new Book { Volume = Volume.Third });
            cart.Add(new Book { Volume = Volume.Third });

            //assert
            int expected = 460;
            Assert.AreEqual(expected, cart.GetPrice());
        }
    }
}
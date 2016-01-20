using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class CalculatorFeeServiceTests
    {
        [TestMethod]
        public void CalculatorFee_is_1_episode_1_quantity_Fee_Should_Be_100()
        {
            //arrange
            var stubDAO = new StubShoppingCartDao();
            var target = new CalculatorFeeService(stubDAO, 1);

            var expected = 100;

            //act
            var actual = target.CalculatorFee();

            //assert
            Assert.AreEqual(expected, Convert.ToInt32(actual));

        }

        [TestMethod]
        public void CalculatorFee_is_1_episode_1_quantity_2_episode_1_quantity_Fee_Should_Be_190()
        {
            //arrange
            var stubDAO = new StubShoppingCartDao();
            var target = new CalculatorFeeService(stubDAO, 2);

            var expected = 190;

            //act
            var actual = target.CalculatorFee();

            //assert
            Assert.AreEqual(expected, Convert.ToInt32(actual));

        }

        [TestMethod]
        public void CalculatorFee_is_1_episode_1_quantity_2_episode_1_quantity_3_episode_1_quantity_Fee_Should_Be_270()
        {
            //arrange
            var stubDAO = new StubShoppingCartDao();
            var target = new CalculatorFeeService(stubDAO, 3);

            var expected = 270;

            //act
            var actual = target.CalculatorFee();

            //assert
            Assert.AreEqual(expected, Convert.ToInt32(actual));

        }

        [TestMethod]
        public void CalculatorFee_is_1_episode_1_quantity_2_episode_1_quantity_3_episode_1_quantity_4_episode_1_quantity_Fee_Should_Be_320()
        {
            //arrange
            var stubDAO = new StubShoppingCartDao();
            var target = new CalculatorFeeService(stubDAO, 4);

            var expected = 320;

            //act
            var actual = target.CalculatorFee();

            //assert
            Assert.AreEqual(expected, Convert.ToInt32(actual));

        }

        [TestMethod]
        public void CalculatorFee_is_1_episode_1_quantity_2_episode_1_quantity_3_episode_1_quantity_4_episode_1_quantity_5_episode_1_quantity_Fee_Should_Be_375()
        {
            //arrange
            var stubDAO = new StubShoppingCartDao();
            var target = new CalculatorFeeService(stubDAO, 5);

            var expected = 375;

            //act
            var actual = target.CalculatorFee();

            //assert
            Assert.AreEqual(expected, Convert.ToInt32(actual));

        }

        [TestMethod]
        public void CalculatorFee_is_1_episode_1_quantity_2_episode_1_quantity_3_episode_2_quantity_Fee_Should_Be_370()
        {
            //arrange
            var stubDAO = new StubShoppingCartDao();
            var target = new CalculatorFeeService(stubDAO, 6);

            var expected = 370;

            //act
            var actual = target.CalculatorFee();

            //assert
            Assert.AreEqual(expected, Convert.ToInt32(actual));

        } 
        
    }

    public class StubShoppingCartDao : IShoppingCartDao
    {
        public List<ShoppingCart> GetShoppingCart(int Scenario)
        {
            List<ShoppingCart> ShoppingCartData = null;
            
            switch (Scenario)
            {
                case 1:

                    ShoppingCartData = new List<ShoppingCart>()
                    {
                        new ShoppingCart() { Episode=1 ,BookName="Harry Potter and the Sorcerer's Stone", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=2 ,BookName="Harry Potter and the Chamber of Secrets", SellPrice = 100, Quantity=0 },
                        new ShoppingCart() { Episode=3 ,BookName="Harry Potter and the Prisoner of Azkaban", SellPrice = 100, Quantity=0 },
                        new ShoppingCart() { Episode=4 ,BookName="Harry Potter and the Goblet of Fire", SellPrice = 100, Quantity=0 },
                        new ShoppingCart() { Episode=5 ,BookName="Harry Potter and the Order of the Phoenix", SellPrice = 100, Quantity=0 }
                    };

                    break;
                case 2:

                    ShoppingCartData = new List<ShoppingCart>()
                    {
                        new ShoppingCart() { Episode=1 ,BookName="Harry Potter and the Sorcerer's Stone", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=2 ,BookName="Harry Potter and the Chamber of Secrets", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=3 ,BookName="Harry Potter and the Prisoner of Azkaban", SellPrice = 100, Quantity=0 },
                        new ShoppingCart() { Episode=4 ,BookName="Harry Potter and the Goblet of Fire", SellPrice = 100, Quantity=0 },
                        new ShoppingCart() { Episode=5 ,BookName="Harry Potter and the Order of the Phoenix", SellPrice = 100, Quantity=0 }
                    };

                    break;
                case 3:

                    ShoppingCartData = new List<ShoppingCart>()
                    {
                        new ShoppingCart() { Episode=1 ,BookName="Harry Potter and the Sorcerer's Stone", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=2 ,BookName="Harry Potter and the Chamber of Secrets", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=3 ,BookName="Harry Potter and the Prisoner of Azkaban", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=4 ,BookName="Harry Potter and the Goblet of Fire", SellPrice = 100, Quantity=0 },
                        new ShoppingCart() { Episode=5 ,BookName="Harry Potter and the Order of the Phoenix", SellPrice = 100, Quantity=0 }
                    };

                    break;
                case 4:

                    ShoppingCartData = new List<ShoppingCart>()
                    {
                        new ShoppingCart() { Episode=1 ,BookName="Harry Potter and the Sorcerer's Stone", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=2 ,BookName="Harry Potter and the Chamber of Secrets", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=3 ,BookName="Harry Potter and the Prisoner of Azkaban", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=4 ,BookName="Harry Potter and the Goblet of Fire", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=5 ,BookName="Harry Potter and the Order of the Phoenix", SellPrice = 100, Quantity=0 }
                    };

                    break;
                case 5:

                    ShoppingCartData = new List<ShoppingCart>()
                    {
                        new ShoppingCart() { Episode=1 ,BookName="Harry Potter and the Sorcerer's Stone", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=2 ,BookName="Harry Potter and the Chamber of Secrets", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=3 ,BookName="Harry Potter and the Prisoner of Azkaban", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=4 ,BookName="Harry Potter and the Goblet of Fire", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=5 ,BookName="Harry Potter and the Order of the Phoenix", SellPrice = 100, Quantity=1 }
                    };

                    break;
                case 6:

                    ShoppingCartData = new List<ShoppingCart>()
                    {
                        new ShoppingCart() { Episode=1 ,BookName="Harry Potter and the Sorcerer's Stone", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=2 ,BookName="Harry Potter and the Chamber of Secrets", SellPrice = 100, Quantity=1 },
                        new ShoppingCart() { Episode=3 ,BookName="Harry Potter and the Prisoner of Azkaban", SellPrice = 100, Quantity=2 },
                        new ShoppingCart() { Episode=4 ,BookName="Harry Potter and the Goblet of Fire", SellPrice = 100, Quantity=0 },
                        new ShoppingCart() { Episode=5 ,BookName="Harry Potter and the Order of the Phoenix", SellPrice = 100, Quantity=0 }
                    };

                    break;
                default:                    
                    break;
            }

            return ShoppingCartData;
        }
    }
    
}



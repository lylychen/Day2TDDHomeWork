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
            var target = new CalculatorFeeService();

            var expected = 100;

            //act
            var actual = target.CalculatorFee();

            //assert
            Assert.AreEqual(expected, Convert.ToInt32(actual));

        }        
        
    }
    
}



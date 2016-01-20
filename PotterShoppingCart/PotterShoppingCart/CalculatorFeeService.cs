using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class CalculatorFeeService
    {

        private IShoppingCartDao _ShoppingCartDao;

        public CalculatorFeeService(IShoppingCartDao ShoppingCartDao)
        {
            this._ShoppingCartDao = ShoppingCartDao;
        }

        public int CalculatorFee()
        {
            var ShoppingCarts = _ShoppingCartDao.GetShoppingCart();

            var ordersOfBook = ShoppingCarts.Where(x=>x.Quantity > 0).Sum(x => x.SellPrice * x.Quantity);

            return ordersOfBook;
        }  
    }


    public class ShoppingCartDao : IShoppingCartDao
    {
        List<ShoppingCart> IShoppingCartDao.GetShoppingCart()
        {
            throw new NotImplementedException();
        }
    }

    public interface IShoppingCartDao
    {
        List<ShoppingCart> GetShoppingCart();
    }

    public class ShoppingCart
    {
        public int Episode { get; set; }

        public string BookName { get; set; }

        public int SellPrice { get; set; }

        public int Quantity { get; set; }
    }
    
}

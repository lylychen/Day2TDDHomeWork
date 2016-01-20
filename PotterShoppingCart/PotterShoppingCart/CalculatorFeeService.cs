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
        private int _Scenario;

        public CalculatorFeeService(IShoppingCartDao ShoppingCartDao, int Scenario)
        {
            this._ShoppingCartDao = ShoppingCartDao;
            this._Scenario = Scenario;
        }

        public int CalculatorFee()
        {
            var ShoppingCarts = _ShoppingCartDao.GetShoppingCart(this._Scenario);

           // var TotalFee = ShoppingCarts.Where(x=>x.Quantity).Sum(x => x.SellPrice * x.Quantity);

            var TotalFee = 0;
            var FinalFee = 0;            
            var Episode = 0;
            var Quantity = 0;

            var index = 0;
            while (index < ShoppingCarts.Count)
            {
                if (Episode != ShoppingCarts.ToList()[index].Episode && ShoppingCarts.ToList()[index].Quantity > 0)
                { 
                    TotalFee += ShoppingCarts.ToList()[index].SellPrice * ShoppingCarts.ToList()[index].Quantity;
                    Quantity++;
                }

                Episode = ShoppingCarts.ToList()[index].Episode;
                index += 1;
            }

            switch (Quantity)
            {
                case 1:
                    FinalFee = TotalFee * 100 / 100;
                    break;
                case 2:
                    FinalFee = TotalFee * 95 / 100;
                    break;
                case 3:
                    FinalFee = TotalFee * 90 / 100;
                    break;
                case 4:
                    FinalFee = TotalFee * 80 / 100;
                    break;
                default:
                    FinalFee = TotalFee * 100 / 100;
                    break;
            }

            return FinalFee; 
        }  
    }


    public class ShoppingCartDao : IShoppingCartDao
    {
        List<ShoppingCart> IShoppingCartDao.GetShoppingCart(int Scenario)
        {
            throw new NotImplementedException();
        }
    }

    public interface IShoppingCartDao
    {
        List<ShoppingCart> GetShoppingCart(int Scenario);
    }

    public class ShoppingCart
    {
        public int Episode { get; set; }

        public string BookName { get; set; }

        public int SellPrice { get; set; }

        public int Quantity { get; set; }
    }
    
}

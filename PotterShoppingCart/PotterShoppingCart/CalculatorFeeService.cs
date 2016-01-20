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

            var TotalFee = 0;
            var FinalFee = 0;
            var DiscountGroup = 0;   //折扣組數
            var QuantityTotal = ShoppingCarts.Sum(x => x.Quantity);   //取出總本數

            var i = 0;
            var j = 0;

            while (i < QuantityTotal)
            {
                j = 1;
                while (j <= ShoppingCarts.Count)
                {
                    if (ShoppingCarts.Where(x=>x.Episode == j).ToList()[0].Quantity > 0)
                    {
                        TotalFee += ShoppingCarts.Take(j).ToList()[0].SellPrice;
                        ShoppingCarts.Where(x => x.Episode == j).ToList()[0].Quantity--;
                        DiscountGroup++;
                    }                   

                    j++;
                }                

                switch (DiscountGroup)
                {
                    case 1:
                        FinalFee += TotalFee * 100 / 100;
                        break;
                    case 2:
                        FinalFee += TotalFee * 95 / 100;
                        break;
                    case 3:
                        FinalFee += TotalFee * 90 / 100;
                        break;
                    case 4:
                        FinalFee += TotalFee * 80 / 100;
                        break;
                    case 5:
                        FinalFee += TotalFee * 75 / 100;
                        break;
                }

                QuantityTotal -= DiscountGroup;   //總本數 - 折扣組數
                DiscountGroup = 0;
                TotalFee = 0;
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

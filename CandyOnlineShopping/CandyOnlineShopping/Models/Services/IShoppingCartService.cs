using CandyOnlineShopping.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Services
{
    interface IShoppingCartService
    {
        void AddToCart(Candy candy, int amount);
        int RemoveFromCart(Candy candy);
        IEnumerable<ShoppingCartItem> GetShoppingCartItems();

        decimal GetShoppingCartTotal();
        void ClearCart();
    }
}

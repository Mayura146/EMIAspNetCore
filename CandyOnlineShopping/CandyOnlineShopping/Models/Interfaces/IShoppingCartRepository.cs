using CandyOnlineShopping.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        
        void AddToCart(Candy candy, int amount);
        int RemoveFromCart(Candy candy);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
    }
}

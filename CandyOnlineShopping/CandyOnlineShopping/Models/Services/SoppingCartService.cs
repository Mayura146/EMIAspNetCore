using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Services
{
    public class ShoppingCartService : IShoppingCartService
    {

        private IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public void AddToCart(Candy candy, int amount)
        {
            _shoppingCartRepository.AddToCart(candy, amount);
        }

        public void ClearCart()
        {
            _shoppingCartRepository.ClearCart();
        }

        public IEnumerable<ShoppingCartItem> GetShoppingCartItems()
        {
            return _shoppingCartRepository.GetShoppingCartItems();
        }

        public decimal GetShoppingCartTotal()
        {
            return _shoppingCartRepository.GetShoppingCartTotal();
        }

        public int RemoveFromCart(Candy candy)
        {
            return _shoppingCartRepository.RemoveFromCart(candy);
        }
    }
}

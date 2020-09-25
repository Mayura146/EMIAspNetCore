using CandyOnlineShopping.Models.DataModels;
using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Repositories
{
    public class ShoppingCartRepository : ShoppingCartItem, IShoppingCartRepository
    {
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        private readonly AppDbContext _appDbContext;

        public ShoppingCartRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddToCart(Candy candy, int amount)
        {
            var shoppingcartitem = _appDbContext.ShoppingCartItem.
                  SingleOrDefault(s => s.Candy.Id == candy.Id && s.ShoppingCartId == ShoppingCartId);

            if (shoppingcartitem == null)
            {
                shoppingcartitem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Candy = candy,
                    Amount = amount
                };
                _appDbContext.ShoppingCartItem.Add(shoppingcartitem);
            }

            else
            {
                // increment of u find item in cart

                shoppingcartitem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public void ClearCart()
        {
            var cartitems = _appDbContext.ShoppingCartItem.
                  Where(c => c.ShoppingCartId == ShoppingCartId);
            _appDbContext.ShoppingCartItem.RemoveRange(cartitems);
            _appDbContext.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItem.
               Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Candy).ToList());
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItem.
                 Where(c => c.ShoppingCartId == ShoppingCartId).
                 Select(c => c.Candy.Price * c.Amount).Sum();
            return total;
        }

        public int RemoveFromCart(Candy candy)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItem.
           SingleOrDefault(s => s.Candy.Id == candy.Id && s.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }

                else
                {
                    _appDbContext.ShoppingCartItem.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();
            return localAmount;
        }


    }
}

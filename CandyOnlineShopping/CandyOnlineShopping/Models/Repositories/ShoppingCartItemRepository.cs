using CandyOnlineShopping.Models.DataModels;
using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Repositories
{
    //public class ShoppingCartItemRepository : IShoppingCartRepository
    //{
    //    private AppDbContext _appDbContext;

    //    public ShoppingCartItemRepository(AppDbContext appDbContext)
    //    {
    //        _appDbContext = appDbContext;
    //    }
    //    public void AddToCart(Candy candy, int amount)
    //    {
    //        var shoppingCartItem = _appDbContext.ShoppingCartItem.
    //            SingleOrDefault(s => s.Candy.Id == candy.Id && );
    //    }

    //    public void ClearCart()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public static ShoppingCart GetCart(IServiceProvider serviceProvider)
    //    {
    //        ISession session = serviceProvider.GetRequiredService<IHttpContextAccessor>()
    //            ?.HttpContext.Session;
    //        var context = serviceProvider.GetService<AppDbContext>();
    //        string cartId = session.GetString("Id") ?? Guid.NewGuid().ToString();
    //        session.SetString("Id", cartId);
    //        return new ShoppingCart(context)
    //        {
    //            Id = cartId
    //        };

    //    }

    //    public List<ShoppingCartItem> GetShoppingCartItems()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public decimal GetShoppingCartTotal()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int RemoveFromCart(Candy candy)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
//}

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Test_Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopCarId { get; set; }

        public List<ShopCarItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCarId = shopCartId }; 
        }

        public void AddToCart(Car car)
        {
            this.appDBContent.ShopCarItems.Add(new ShopCarItem
            {
                ShopCarId = ShopCarId,
                car = car,
                price = car.price
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCarItem> getShopItems()
        {
            return appDBContent.ShopCarItems.Where(c => c.ShopCarId == ShopCarId).Include(s => s.car).ToList();
        }
    }
}

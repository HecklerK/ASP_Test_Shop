using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Test_Shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Test_Shop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Car> Car {  get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCarItem> ShopCarItems { get; set; }
    }
}

using ASP_Test_Shop.Data.Interfaces;
using ASP_Test_Shop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Test_Shop.Data
{
    public class DBObject
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "BMW",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/bmw.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Nissan",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/nissan.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var List = new Category[]
                    {
                    new Category { categoryName = "Электромобили", categoryDescription = "Машины с электродвигателем" },
                    new Category { categoryName = "Классические автомобили", categoryDescription = "Машины с двигателем внутроеннего згорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in List)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}

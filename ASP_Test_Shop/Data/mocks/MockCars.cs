using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Test_Shop.Data.Interfaces;
using ASP_Test_Shop.Data.Models;
using static System.Net.WebRequestMethods;

namespace ASP_Test_Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Name = "Tesla",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = carsCategory.AllCategories.First()
                    },
                    new Car { Name = "BMW",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/bmw.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = false,
                        Category = carsCategory.AllCategories.Last()
                    },
                    new Car { Name = "Nissan",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/nissan.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = carsCategory.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int idCar)
        {
            throw new NotImplementedException();
        }
    }
}

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
                        img = "https://cdn.carbuzz.com/gallery-images/1600/663000/600/663626.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = carsCategory.AllCategories.First()
                    },
                    new Car { Name = "BMW",
                        shortDescription = "",
                        longDescription = "",
                        img = "https://avatars.mds.yandex.net/get-pdb/1757027/6f435fc7-d8c4-4b24-95a0-19101805ba71/s1200",
                        price = 45000,
                        isFavourite = true,
                        available = false,
                        Category = carsCategory.AllCategories.Last()
                    },
                    new Car { Name = "Nissan",
                        shortDescription = "",
                        longDescription = "",
                        img = "https://avatars.mds.yandex.net/get-zen_doc/3401641/pub_5f29d617c4a79e57b738f2ad_5f29d621b0d961407f9f1f3d/scale_1200",
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

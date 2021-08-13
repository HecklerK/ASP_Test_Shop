using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Test_Shop.Data.Interfaces;
using ASP_Test_Shop.Data.Models;

namespace ASP_Test_Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", categoryDescription = "Машины с электродвигателем" },
                    new Category { categoryName = "Классические автомобили", categoryDescription = "Машины с двигателем внутроеннего згорания" }
                };
            }
        }
    }
}

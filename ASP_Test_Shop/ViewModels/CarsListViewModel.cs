using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Test_Shop.Data.Models;

namespace ASP_Test_Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory {  get; set; }
    }
}

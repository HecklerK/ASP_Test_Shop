using ASP_Test_Shop.Data.Interfaces;
using ASP_Test_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Test_Shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRepository;

        public HomeController(IAllCars carRep)
        {
            _carRepository = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRepository.getFavCars
            };
            return View(homeCars);
        }
    }
}

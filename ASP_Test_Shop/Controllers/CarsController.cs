using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Test_Shop.Data.Interfaces;
using ASP_Test_Shop.ViewModels;

namespace ASP_Test_Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory carsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            allCars = iAllCars;
            carsCategory = iCarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}

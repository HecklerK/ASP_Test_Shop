﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Test_Shop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<Car> cars { get; set; }
    }
}

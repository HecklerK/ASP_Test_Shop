using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Test_Shop.Data.Models;

namespace ASP_Test_Shop.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

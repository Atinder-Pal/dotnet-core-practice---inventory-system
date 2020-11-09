using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystemDay1.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystemDay1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public Product CreateProduct(string name, string quantity, string discontinued)
        {

            return null;
        }
     }
}

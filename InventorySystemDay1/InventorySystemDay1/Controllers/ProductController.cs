using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystemDay1.Models;
using InventorySystemDay1.Models.Exceptions;
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
            int parsedQuantity = 0;
            bool parsedDiscontinued = false;
            ValidationException exception = new ValidationException();

            name = (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) ? null : name;
            quantity = (string.IsNullOrEmpty(quantity) || string.IsNullOrWhiteSpace(quantity)) ? null : quantity;
            discontinued = (string.IsNullOrEmpty(discontinued) || string.IsNullOrWhiteSpace(discontinued)) ? null : discontinued;

            using (InventoryContext context = new InventoryContext())
            {
                if(string.IsNullOrWhiteSpace(name))
                {
                    exception.ValidationExceptions.Add(new ArgumentNullException(nameof(name), nameof(name) + " is null."));
                }
                else
                {
                    if(context.Products.Any(x=> x.Name.ToLower() == name.ToLower()))
                    {
                        exception.ValidationExceptions.Add(new Exception("Product already exists"));
                    }
                }
                if (string.IsNullOrWhiteSpace(quantity))
                {
                    parsedQuantity = 0;
                }
                else
                {
                    if(!int.TryParse(quantity, out parsedQuantity))
                    {
                        exception.ValidationExceptions.Add(new Exception("Invalid Quantity Value"));
                    }
                    else
                    {
                        if(parsedQuantity < 0)
                        {
                            parsedQuantity = 0;
                        }
                    }                    
                }
                if (string.IsNullOrWhiteSpace(discontinued))
                {
                    parsedDiscontinued = false;
                }
                else
                {
                    if(!bool.TryParse(discontinued, out parsedDiscontinued))
                    {
                        exception.ValidationExceptions.Add(new Exception("Value of Discontinued should be eithe true or false"));
                    }                    
                }
                if (exception.ValidationExceptions.Count > 0)
                {
                    throw exception;
                }
                Product newProduct = new Product()
                {
                    Name = name,
                    Quantity = parsedQuantity,
                    Discontinued = parsedDiscontinued
                };
                context.Products.Add(newProduct);
                context.SaveChanges();

                return newProduct;
            }                
        }
     }
}

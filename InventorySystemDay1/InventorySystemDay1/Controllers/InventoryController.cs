﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using InventorySystemDay1.Models;
using InventorySystemDay1.Models.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystemDay1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        [HttpPost("Create")]
        public ActionResult<Product> ProductCreate_POST(string name, string quantity, string discontinued)
        {
            ActionResult<Product> result;
            try
            {
                result = new ProductController().CreateProduct(name, quantity, discontinued);
            }
            catch (ValidationException e)
            {
                string error = "Error(s) During Creation: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception e)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;
        }
    }
}

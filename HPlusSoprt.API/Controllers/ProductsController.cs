using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPlusSoprt.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSoprt.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;
            context.Database.EnsureCreated();
        }

        [HttpGet]
        public IActionResult GetAllProducts() {
            return Ok(_context.Products.ToArray());
        }

        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            return Ok(product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eshopCrud.Controllers
{
    
    public class ProductsController : Controller
    {
        private readonly MyDbContext myDbContext;

        public ProductsController(MyDbContext context){
            myDbContext = context;
        }

        public IActionResult Index()
        {

            var products = myDbContext.Products.ToList();
            return View();
        }
    }
}


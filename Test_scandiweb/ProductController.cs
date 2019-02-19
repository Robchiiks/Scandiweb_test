using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_scandiweb.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test_scandiweb
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ProductContext context = HttpContext.RequestServices.GetService(typeof(Test_scandiweb.Model.ProductContext)) as ProductContext;

            return View(context.GetAllProducts());
        }
    }
}

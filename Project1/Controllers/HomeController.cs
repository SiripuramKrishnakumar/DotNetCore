using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KKTextiles.Controllers
{
    
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("customerslist")]
        public IActionResult CustomersList()
        {
            return View();
        }
    }
}

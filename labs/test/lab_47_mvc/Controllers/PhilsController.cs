using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab_47_mvc.Controllers
{
    public class PhilsController : Controller
    {
        public List<String> list = new List<string>();
        public IActionResult Index()
        {
            return View(list);
        }
    }
}

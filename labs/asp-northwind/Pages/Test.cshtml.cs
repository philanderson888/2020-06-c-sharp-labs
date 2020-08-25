using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_northwind.Pages
{
    public class TestModel : PageModel
    {
        public List<string> list = new List<string>() { "hello", "there" };
        public List<string> list2 = new List<string>() { "hello", "there" };
        public void OnGet()
        {

        }
    }
}

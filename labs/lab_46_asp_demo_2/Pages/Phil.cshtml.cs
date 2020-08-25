using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_46_asp_demo_2.Pages
{
    public class PhilModel : PageModel
    {

        public static List<string> items = new List<string>() { "one", "two", "three" };

        public void OnGet()
        {
            items.Add("another item");

            // ViewBag and ViewData
            // Scratchpad data to throw onto screen
            // Collection of strings
            ViewData["ThisDataField"] = "Some Data Stored Here";
           

        }
    }
}

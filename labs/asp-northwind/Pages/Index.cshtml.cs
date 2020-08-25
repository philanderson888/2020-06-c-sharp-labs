using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_northwind.Models;

namespace asp_northwind.Pages
{
    public class IndexModel : PageModel
    {
        private readonly asp_northwind.Models.NorthwindContext _context;

        public IndexModel(asp_northwind.Models.NorthwindContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleCRUDApp_Razor.Data;
using SimpleCRUDApp_Razor.Models;

namespace SimpleCRUDApp_Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SimpleCRUDApp_Razor.Data.SimpleCRUDApp_RazorContext _context;

        public IndexModel(SimpleCRUDApp_Razor.Data.SimpleCRUDApp_RazorContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}

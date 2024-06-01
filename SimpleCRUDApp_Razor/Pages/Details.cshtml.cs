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
    public class DetailsModel : PageModel
    {
        private readonly SimpleCRUDApp_Razor.Data.SimpleCRUDApp_RazorContext _context;

        public DetailsModel(SimpleCRUDApp_Razor.Data.SimpleCRUDApp_RazorContext context)
        {
            _context = context;
        }

        public Products Products { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            else
            {
                Products = products;
            }
            return Page();
        }
    }
}

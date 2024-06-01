using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleCRUDApp_Razor.Data;
using SimpleCRUDApp_Razor.Models;

namespace SimpleCRUDApp_Razor.Pages
{
    public class CreateModel : PageModel
    {
        private readonly SimpleCRUDApp_Razor.Data.SimpleCRUDApp_RazorContext _context;

        public CreateModel(SimpleCRUDApp_Razor.Data.SimpleCRUDApp_RazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Products Products { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

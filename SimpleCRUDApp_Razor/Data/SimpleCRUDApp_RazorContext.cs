using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleCRUDApp_Razor.Models;

namespace SimpleCRUDApp_Razor.Data
{
    public class SimpleCRUDApp_RazorContext : DbContext
    {
        public SimpleCRUDApp_RazorContext (DbContextOptions<SimpleCRUDApp_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleCRUDApp_Razor.Models.Products> Products { get; set; } = default!;
    }
}

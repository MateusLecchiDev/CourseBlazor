using Microsoft.EntityFrameworkCore;
using BlazorServerScaffolding.Entities;

namespace BlazorServerScaffolding.Data
{
    public class BlazorServerScaffoldingContext : DbContext
    {
        public BlazorServerScaffoldingContext (DbContextOptions<BlazorServerScaffoldingContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
    }
}

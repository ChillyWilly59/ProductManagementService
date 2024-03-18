using Microsoft.EntityFrameworkCore;
using ProductManagementService.Data.Model;

namespace ProductManagementService.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MyBooksWeb.Models;

namespace MyBooksWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}

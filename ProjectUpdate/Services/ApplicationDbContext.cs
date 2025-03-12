using Microsoft.EntityFrameworkCore;
using ProjectUpdate.Models;

namespace ProjectUpdate.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movies> Movie { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Newsletter.Api.Entities;

namespace Newsletter.Api.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Articale> Articales { get; set; }
    }
}

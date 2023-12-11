using Microsoft.EntityFrameworkCore;
using MovieRate.Models;


namespace MovieRate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            }
            public DbSet<MovieEntity> Movie {get; set;}
        
    }
}
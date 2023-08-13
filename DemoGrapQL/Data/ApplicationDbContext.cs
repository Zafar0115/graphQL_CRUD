using DemoGrapQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoGrapQL.Data
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}

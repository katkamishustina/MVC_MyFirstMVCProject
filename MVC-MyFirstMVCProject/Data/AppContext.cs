using Microsoft.EntityFrameworkCore;
using MVC_MyFirstMVCProject.Models;

namespace MVC_MyFirstMVCProject.Data
{
    public class AppContext: DbContext
    {
        // This class is like a main bridge connecting the project with a database
        // Here we store every instance
        public AppContext(DbContextOptions<AppContext> options):base(options) { }

        public DbSet<Item> Items { get; set;}
    }
}

// Importing necessary namespaces
using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

// Defining a database context class that inherits from DbContext
namespace BulkyBookWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        // Constructor to initialize the database context with options
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            // The base constructor is called with the provided options
        }

        // DbSet property for the Category model, representing a database table
        public DbSet<Category> Categories { get; set; }
    }
}

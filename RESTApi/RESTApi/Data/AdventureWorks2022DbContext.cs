using Microsoft.EntityFrameworkCore;

namespace RESTApi.Data
{
    public class AdventureWorks2022DbContext : DbContext
    {
        // Constructor to pass DbContextOptions to the base class
        public AdventureWorks2022DbContext(DbContextOptions<AdventureWorks2022DbContext> options)
            : base(options)
        {
        }

        // DbSet for the Product entity
        public DbSet<Product> Products { get; set; }
    }
}

using System.Data.Entity;

namespace vidli.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        //Entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}

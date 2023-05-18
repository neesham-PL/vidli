using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
    }
}

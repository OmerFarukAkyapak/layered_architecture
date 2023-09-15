using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class BarnContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Barn;Trusted_Connection=true");
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Barn> Farm { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

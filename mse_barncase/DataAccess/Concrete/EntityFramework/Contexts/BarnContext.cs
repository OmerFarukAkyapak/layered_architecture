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

        public DbSet<Animal> Animal { get; set; }
        public DbSet<Barn> Farm { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<AnimalTypes> AnimalTypes { get; set; }
        public DbSet<AnimalGenders> AnimalGenders { get; set; }
        public DbSet<ProductTypes> ProductTypes { get; set; }

    }
}

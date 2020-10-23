using DemoWebAPI.Configurations;
using DemoWebAPI.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Models
{
    public class DemoWebContext : DbContext
    {

        public DemoWebContext(DbContextOptions<DemoWebContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using FluentAPI

            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            //Data Seeding
            modelBuilder.Seed();
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }

}

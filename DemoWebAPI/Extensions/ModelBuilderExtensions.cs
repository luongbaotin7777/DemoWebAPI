using DemoWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DemoWebAPI.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products()
                {
                    Id = 1,
                    Name = "Iphone 7Plus",
                    Price = 7000000,
                    Description = "Iphone 7Plus 64Gb, new Model in Years",
                    //ProductInCategories = new List<ProductInCategory>()
                    //{
                    //    new ProductInCategory(){CategoryId = 1,ProductId =1}
                    //}
                },
                new Products()
                {
                    Id = 2,
                    Name = "Iphone 8Plus",
                    Price = 15000000,
                    Description = "Iphone 8Plus 64Gb, new Model in Years",
                    //ProductInCategories = new List<ProductInCategory>(){
                    //new ProductInCategory(){CategoryId=1,ProductId =1}
                    //}
                },
                new Products()
                {
                    Id = 3,
                    Name = "SamSung Note10",
                    Price = 10000000,
                    Description = "SamSung Note10 256GB, new Model in Years",
                    //ProductInCategories = new List<ProductInCategory>(){
                    //new ProductInCategory(){CategoryId=1,ProductId =1}
                    //}
                },
                new Products()
                {
                    Id = 4,
                    Name = "SamSung Note9",
                    Price = 9000000,
                    Description = "SamSung Note9 64Gb, new Model in Years",
                    //ProductInCategories = new List<ProductInCategory>(){
                    //new ProductInCategory(){CategoryId=1,ProductId =1}
                    //}
                },
                new Products()
                {
                    Id = 5,
                    Name = "LG ABCD G15",
                    Price = 11000000,
                    Description = "LG ABCD G15 64Gb, new Model in Years",
                    //ProductInCategories = new List<ProductInCategory>(){
                    //new ProductInCategory(){CategoryId=1}
                    //}
                }

                );
            modelBuilder.Entity<Categories>().HasData(
                new Categories() { Id = 1, Name = "Iphone" },
                new Categories() { Id = 2, Name = "SamSung" },
                new Categories() { Id = 3, Name = "LG" }
                );

        }
    }
}

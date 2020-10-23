using DemoWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(k => new { k.CategoryId, k.ProductId });
            builder.HasOne(k => k.Product).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(k => k.ProductId);
            builder.HasOne(k => k.Category).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.CategoryId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}

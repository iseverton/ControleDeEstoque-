using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Data.Configurations;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasColumnName("id")
            .HasColumnType("int")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(p => p.BarCode)
            .HasColumnName("bar_code")
            .HasColumnType("varchar(14)")
            .IsRequired();

        builder.Property(p => p.Price)
            .HasColumnName("price")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(p => p.CurrentStock)
            .HasColumnName("current_stock")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.MinimumStock)
            .HasColumnName("minimum_stock")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.ExpirationDate)
            .HasColumnName("expiration_date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(p => p.IsActive)
            .HasColumnName("is_active")
            .HasColumnType("bit")
            .IsRequired();

        // Relacionamnetos

        builder.HasMany(p => p.Categories)
            .WithMany(c => c.Products)
            .UsingEntity(j => j.ToTable("ProductCategory"));

        
        builder.HasOne(s => s.Supplier)
            .WithMany(p => p.Products)
            .HasForeignKey(s => s.SupplierId);   
    }
}

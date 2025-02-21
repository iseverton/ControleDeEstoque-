using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Data.Configurations;

public class LowStockWarningsMap : IEntityTypeConfiguration<LowStockWarnings>
{
    public void Configure(EntityTypeBuilder<LowStockWarnings> builder)
    {
        builder.ToTable("LowStockWarnings");
        builder.HasKey(l => l.Id);

        builder.Property(l => l.ProductId)
            .HasColumnName("product_id")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(l => l.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        // Relacionamentos

        builder.HasOne(p => p.Product)
            .WithMany(l => l.LowStockWarnings)
            .HasForeignKey(p => p.ProductId)
            .IsRequired();
    }
}

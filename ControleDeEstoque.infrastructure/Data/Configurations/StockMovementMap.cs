using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Data.Configurations;

public class StockMovementMap : IEntityTypeConfiguration<StockMovement>
{
    public void Configure(EntityTypeBuilder<StockMovement> builder)
    {
        builder.ToTable("StockMovement");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.ProductId)
            .HasColumnName("product_id")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Quantity)
            .HasColumnName("quantity")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(s=> s.MovementDate)
            .HasColumnName("movement_date")
            .HasColumnType("datetime")
            .IsRequired();

        // Relacionamentos

        builder.HasOne(u => u.User)
            .WithMany(s => s.StockMovements)
            .HasForeignKey(u=> u.ResponsibleUser)
            .IsRequired();

        builder.HasOne(p => p.Product)
            .WithMany(s => s.StockMovements)
            .HasForeignKey(p => p.ProductId)
            .IsRequired();


    }
}

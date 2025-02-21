using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Data.Configurations;

public class SupplierMap : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.ToTable("Supplier");
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(s=> s.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(s => s.UpdatedAt)
            .HasColumnName("updated_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(s => s.Document)
            .HasColumnName("document")
            .HasColumnType("varchar(14)")
            .IsRequired();

        builder.Property(s => s.Email)
            .HasColumnName("email")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(s => s.Phone)
            .HasColumnName("phone")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.Property(s => s.PostalCode)
            .HasColumnName("postal_code")
            .HasColumnType("varchar(8)")
            .IsRequired();

        builder.Property(s => s.State)
            .HasColumnName("state")
            .HasColumnType("varchar(2)")
            .IsRequired();

        builder.Property(s => s.City)
            .HasColumnName("city")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(s => s.Street)
            .HasColumnName("street")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(s => s.Number)
            .HasColumnName("number")
            .HasColumnType("varchar(10)")
            .IsRequired();

        builder.Property(s => s.IsActive)
            .HasColumnName("is_active")
            .HasColumnType("bit")
            .IsRequired();
    }
}

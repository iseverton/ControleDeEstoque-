using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Data.Configurations;

public class RoleMap : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("role");

        builder.Property(r=> r.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(r => r.UpdatedAt)
            .HasColumnName("updated_at")
            .HasColumnType("datetime")
            .IsRequired();
    }
}

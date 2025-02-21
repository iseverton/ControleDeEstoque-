using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Data.Configurations
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            ////builder.ToTable("Category");
            //builder.HasKey(c => c.Id);
            
            //builder.Property(c=> c.Id)
            //    .HasColumnName("id")
            //    .HasColumnType("int")
            //    .ValueGeneratedOnAdd()
            //    .IsRequired();


            //builder.Property(c => c.Name)
            //    .HasColumnName("name")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .IsRequired();

            //builder.Property(c => c.Description)
            //    .HasColumnName("description")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(100)
            //    .IsRequired();

            //builder.Property(c => c.CreatedAt)
            //    .HasColumnName("created_at")
            //    .HasColumnType("datetime")
            //    .IsRequired();

            //builder.Property(c => c.UpdatedAt)
            //    .HasColumnName("updated_at")
            //    .HasColumnType("datetime")
            //    .IsRequired();
        }
    }
}

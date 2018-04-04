using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoMenuWeb.Domain.Entities;

namespace ProjetoMenuWeb.Infra.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Code)
                .HasColumnName("Codigo")
                .IsRequired();

            builder.Property(p => p.Brand)
                .HasColumnType("varchar(100)")
                .HasColumnName("Marca")
                .IsRequired();

            builder.Property(p => p.Model)
                .HasColumnType("varchar(100)")
                .HasColumnName("Modelo")
                .IsRequired();

            builder.Property(p => p.Date)
                .HasColumnName("Data")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(100)")
                .HasColumnName("Descrição")
                .IsRequired();

            builder.Property(p => p.Amount)
                .HasColumnName("Quantidade")
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnName("Valor")
                .IsRequired();

            builder.Property(p => p.Total)
                .HasColumnName("Total")
                .IsRequired();
        }
    }
}
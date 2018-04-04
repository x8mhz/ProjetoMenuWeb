using Microsoft.EntityFrameworkCore;
using ProjetoMenuWeb.Domain.Entities;
using ProjetoMenuWeb.Infra.Data.Mappings;

namespace ProjetoMenuWeb.Infra.Data.Context
{
    public class ProjetoMenuWebContext : DbContext
    {
        public ProjetoMenuWebContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbProjetoMenuWeb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}
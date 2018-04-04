using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProjetoMenuWeb.Domain.Context
{
    public class ProjetoMenuWebFactory : IDesignTimeDbContextFactory<ProjetoMenuWebContext>
    {
        public ProjetoMenuWebContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjetoMenuWebContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbProjetoMenuWeb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new ProjetoMenuWebContext(optionsBuilder.Options);
        }
    }
}
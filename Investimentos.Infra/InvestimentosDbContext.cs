using Investimentos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investimentos.Infra
{
    public class InvestimentosDbContext : DbContext
    {
        public InvestimentosDbContext(DbContextOptions<InvestimentosDbContext> opts)
            : base(opts)
        {

        }

        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Banco> Bancos { get; set;}
        public DbSet<Conta> Contas { get; set; }
    }
}

using Investimentos.Domain.Entities;
using Investimentos.Domain.Interfaces.Repositories;

namespace Investimentos.Infra.Repositories
{
    public class ContaRepository : IContaRepository
    {
        private readonly InvestimentosDbContext _context;

        public ContaRepository(InvestimentosDbContext context)
        {
            _context = context;
        }

        public Conta SalvarConta(Conta conta)
        {
            _context.Contas.Add(conta);
            _context.SaveChanges();
            return conta;
        }
    }
}

using Investimentos.Domain.Entities;

namespace Investimentos.Domain.Interfaces.Repositories
{
    public interface IContaRepository
    {
        Conta SalvarConta(Conta conta);
    }
}

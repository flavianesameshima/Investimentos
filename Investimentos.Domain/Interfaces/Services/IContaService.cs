using Investimentos.Domain.Entities;

namespace Investimentos.Domain.Interfaces.Services
{
    public interface IContaService
    {
        Conta SalvarConta(Conta conta);
    }
}

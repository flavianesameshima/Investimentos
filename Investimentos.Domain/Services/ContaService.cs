using Investimentos.Domain.Entities;
using Investimentos.Domain.Interfaces.Repositories;
using Investimentos.Domain.Interfaces.Services;

namespace Investimentos.Domain.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _repository;

        public ContaService(IContaRepository repository)
        {
            _repository = repository;
        }

        public Conta SalvarConta(Conta conta)
        {
            var response = _repository.SalvarConta(conta);
            return response;
        }
    }
}

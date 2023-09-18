using Investimentos.Infra.Dtos;
using Investimentos.Infra.Repositories.Conta;

namespace Investimentos.Aplication.Banco
{
    public class ContaAplication : IContaAplication
    {
        private readonly IContaRepository _repository;
        public ContaAplication(ContaRepository repository)
        {
            _repository = repository;
        }
        public ContaDTO DeleteConta(string id)
        {
            throw new NotImplementedException();
        }

        public ContaDTO EditConta(ContaDTO conta)
        {
            throw new NotImplementedException();
        }

        public ContaDTO GetAllConta(ContaDTO conta)
        {
            throw new NotImplementedException();
        }

        public ContaDTO GetContaById(string id)
        {
            throw new NotImplementedException();
        }

        public ContaDTO SaveConta(ContaDTO conta)
        {
            throw new NotImplementedException();
        }
    }
}

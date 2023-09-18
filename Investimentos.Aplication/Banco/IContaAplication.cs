using Investimentos.Infra.Dtos;

namespace Investimentos.Aplication.Banco
{
    public interface IContaAplication
    {
        ContaDTO GetContaById(string id);
        ContaDTO GetAllConta(ContaDTO conta);
        ContaDTO SaveConta(ContaDTO conta); 
        ContaDTO EditConta(ContaDTO conta);
        ContaDTO DeleteConta(string id);
    }
}

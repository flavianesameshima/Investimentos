using Investimentos.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Investimentos.Infra.Dtos
{
    public class ContaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Banco Banco { get; set; }
        public double Taxa { get; set; }

    }
}

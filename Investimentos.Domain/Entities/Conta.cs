using System.ComponentModel.DataAnnotations;

namespace Investimentos.Domain.Entities
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public int BancoId { get; private set; }

        public Conta(string nome, double valor, int bancoId)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.BancoId = bancoId;
        }
    }
}

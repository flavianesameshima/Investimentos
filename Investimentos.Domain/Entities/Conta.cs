using System.ComponentModel.DataAnnotations;

namespace Investimentos.Domain.Entities
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public Banco Banco { get; private set; }
        public double Taxa { get; private set; }

        public Conta(string nome, double valor, Banco banco, double taxa)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Banco = banco;
            this.Taxa = taxa;
        }
    }
}

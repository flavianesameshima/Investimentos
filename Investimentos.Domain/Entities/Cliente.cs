using Investimentos.Domain.Enuns;
using System.ComponentModel.DataAnnotations;

namespace Investimentos.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public Sexo Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Cliente(string nome, Sexo sexo, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.DataNascimento = dataNascimento;
        }
    }
}

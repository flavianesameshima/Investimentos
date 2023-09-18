using System.ComponentModel.DataAnnotations;

namespace Investimentos.Domain.Entities
{
    public class Banco
    {
        [Key] 
        public int Id { get; set; }   
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public Banco(string nome, double saldo) 
        { 
            Nome = nome;
            Saldo = saldo;
        }
    }
}

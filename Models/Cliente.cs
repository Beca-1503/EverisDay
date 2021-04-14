using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Cliente
    {
        [Key] //chave primaria
        public string CPF { get; set; }
        public string Nome { get; set; }
        [Column("DATA_NASCIMENTO")]
        public string Data_Nascimento { get; set; }
        public string Telefone { get; set; }


        public Cliente(string nome, string data_Nascimento, string telefone, string cpf)
        {
            Nome = nome;
            Data_Nascimento = data_Nascimento;
            Telefone = telefone;
            CPF = cpf;
        }

        public Cliente()
        {

        }
    }
}

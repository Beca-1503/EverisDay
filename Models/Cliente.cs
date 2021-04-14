using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "Campo Obrigatorio*")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio*" )]
        public string Data_Nascimento { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio*")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio*")]
        [Key] //chave primaria
        public string CPF { get; set; }
        

        public override string ToString()
        {
            return "teste";
        }

        //public Cliente(string nome, string data_Nascimento, string telefone, string cpf)
        //{
        //    Nome = nome;
        //    Data_Nascimento = data_Nascimento;
        //    Telefone = telefone;
        //    CPF = cpf;
        //}

    }
}

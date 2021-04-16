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
<<<<<<< HEAD
        [Key]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF composto de 11 dígitos")]
        [Required]
        [RegularExpression(@"\d+", ErrorMessage = "Informe um CPF composto apenas de números")]
        public string CPF { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
=======
        [Key] //chave primaria
        public string CPF { get; set; }
        public string Nome { get; set; }
        [Column("DATA_NASCIMENTO")]
>>>>>>> Layout
        public string Data_Nascimento { get; set; }
        [RegularExpression(@"\d+", ErrorMessage = "Informe o telefone composto apenas de números")]
        public string Telefone { get; set; }
<<<<<<< HEAD
=======

>>>>>>> Layout

        public Cliente()
        {
        }

        public Cliente(string nome, string data_Nascimento, string telefone, string cpf)
        {
            Nome = nome;
            Data_Nascimento = data_Nascimento;
            Telefone = telefone;
            CPF = cpf;
        }
    }
}

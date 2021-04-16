﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Endereco
    {
        [Key]
        [Display(Name = "Endereço")]
        public int IdEndereco { get; set; }
        [Display(Name = "Cidade")]
        public int IdCidade { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string CEP { get; set; }
    }
}

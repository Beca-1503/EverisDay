﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Cidade
    {
        [Key]
        public int IdCidade { get; set; }
        public string Estado { get; set; }
        public string Uf { get; set; }
        public string Nome { get; set; }
    }
}
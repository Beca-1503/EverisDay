﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Cliente
    {
        
        public string Nome { get; set; }
        public string Data_Nascimento { get; set; }

        public string Telefone { get; set; }
        [Key] //chave primaria
        public string CPF { get; set; }

        public Cliente(string nome, string dataNascimento, string telefone, string cpf)
        {
            Nome = nome;
            Data_Nascimento = dataNascimento;
            Telefone = telefone;
            CPF = cpf;
        }
    }
}
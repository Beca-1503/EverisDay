using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Produtos
    {
        [Key]
        public int Id_Produto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Tamanho { get; set; }
        public string Descricao { get; set; }


    }
}

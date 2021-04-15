using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string CPF { get; set; }
        public string DataPedido { get; set; }
        public double PrecoTotal { get; set; }
        public string FormaDePagamento { get; set; }
    }
}

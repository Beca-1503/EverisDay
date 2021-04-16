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
        public string Data_Pedido { get; set; }
        public decimal Preco_Total { get; set; }
        public string Forma_De_Pagamento { get; set; }

        public Pedido()
        {

        }
    }
}

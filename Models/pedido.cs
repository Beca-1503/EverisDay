using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string CPF { get; set; }
        [Column ("DATA_PEDIDO")]
        public string DataPedido { get; set; }
        [Column("PRECO_TOTAL")]
        public decimal PrecoTotal { get; set; }
        [Column("FORMA_DE_PAGAMENTO")]
        public string FormaDePagamento { get; set; }
    }
}

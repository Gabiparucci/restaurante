using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteAnte.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
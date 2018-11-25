using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteAnte.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
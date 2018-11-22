﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteAnte.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public int PratoID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public double vTotal { get; set; }
        

        public virtual Prato Prato { get; set; }
    }
}
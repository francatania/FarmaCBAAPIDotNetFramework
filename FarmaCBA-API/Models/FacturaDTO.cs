using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FacturaDTO
    {
        public int ID_FACTURA { get; set; }
        public DateTime? FECHA { get; set; }
        public string CLIENTE { get; set; }
        public decimal TOTAL { get; set; }
    }
}
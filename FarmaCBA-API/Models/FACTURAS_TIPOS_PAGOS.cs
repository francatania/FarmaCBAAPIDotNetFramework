namespace WebApplication1.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FACTURAS_TIPOS_PAGOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_FACTURA_TIPO_PAGO { get; set; }

        public int ID_FACTURA { get; set; }

        public int? ID_TIPO_PAGO { get; set; }

        public decimal? PORCENTAJE_PAGO { get; set; }

        public bool? ES_CUOTAS { get; set; }

        public int? CANTIDAD_CUOTAS { get; set; }

        [JsonIgnore]
        public virtual FACTURAS FACTURAS { get; set; }
    }
}

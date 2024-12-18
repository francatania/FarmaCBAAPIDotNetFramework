namespace WebApplication1.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DISPENSACIONES
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_FACTURA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_DISPENSACION { get; set; }

        public int? ID_MEDICAMENTO_LOTE { get; set; }

        public int? ID_COBERTURA { get; set; }

        public int? ID_PRODUCTO { get; set; }

        public decimal? DESCUENTO { get; set; }

        public decimal PRECIO_UNITARIO { get; set; }

        public int CANTIDAD { get; set; }

        [StringLength(20)]
        public string MATRICULA { get; set; }

        [StringLength(20)]
        public string CODIGO_VALIDACION { get; set; }

        [JsonIgnore]
        public virtual FACTURAS FACTURAS { get; set; }
    }
}

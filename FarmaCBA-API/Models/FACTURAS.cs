namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FACTURAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURAS()
        {
            DISPENSACIONES = new HashSet<DISPENSACIONES>();
            FACTURAS_TIPOS_PAGOS = new HashSet<FACTURAS_TIPOS_PAGOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_FACTURA { get; set; }

        public int ID_CLIENTE { get; set; }

        public int? ID_PERSONAL_CARGOS_ESTABLECIMIENTOS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FECHA { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISPENSACIONES> DISPENSACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS_TIPOS_PAGOS> FACTURAS_TIPOS_PAGOS { get; set; }

        public virtual PERSONAL_CARGOS_ESTABLECIMIENTOS PERSONAL_CARGOS_ESTABLECIMIENTOS { get; set; }
    }
}

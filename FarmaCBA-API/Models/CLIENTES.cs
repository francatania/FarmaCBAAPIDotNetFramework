namespace WebApplication1.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES()
        {
            FACTURAS = new HashSet<FACTURAS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string APELLIDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_NACIMIENTO { get; set; }

        [Required]
        [StringLength(100)]
        public string CALLE { get; set; }

        [StringLength(10)]
        public string NUMERO { get; set; }

        public int ID_BARRIO { get; set; }

        public int TIPO_DOC { get; set; }

        [Required]
        [StringLength(20)]
        public string NRO_DOC { get; set; }

        public int? ID_GENERO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [JsonIgnore]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }
    }
}

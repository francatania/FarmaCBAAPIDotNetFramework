namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSONAL")]
    public partial class PERSONAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONAL()
        {
            PERSONAL_CARGOS_ESTABLECIMIENTOS = new HashSet<PERSONAL_CARGOS_ESTABLECIMIENTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PERSONAL { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string APELLIDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_NAC { get; set; }

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

        [StringLength(255)]
        public string PSW { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONAL_CARGOS_ESTABLECIMIENTOS> PERSONAL_CARGOS_ESTABLECIMIENTOS { get; set; }
    }
}

namespace WebApplication1.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONAL_CARGOS_ESTABLECIMIENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONAL_CARGOS_ESTABLECIMIENTOS()
        {
            FACTURAS = new HashSet<FACTURAS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PERSONAL_CARGOS_ESTABLECIMIENTOS { get; set; }

        public int ID_PERSONAL { get; set; }

        public int ID_CARGO { get; set; }

        public int ID_ESTABLECIMIENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [JsonIgnore]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        [JsonIgnore]
        public virtual PERSONAL PERSONAL { get; set; }
    }
}

namespace Курорт.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoodTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodTypes()
        {
            Requests = new HashSet<Requests>();
        }

        [Key]
        [StringLength(2)]
        public string FoodTypeID { get; set; }

        [StringLength(25)]
        public string FoodTypeName { get; set; }

        [Column(TypeName = "money")]
        public decimal? FoodTypePrice { get; set; }

        [StringLength(40)]
        public string FoodTypeDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}

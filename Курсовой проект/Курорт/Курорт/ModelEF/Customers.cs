namespace Курорт.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            Requests = new HashSet<Requests>();
        }

        [Key]
        [StringLength(3)]
        public string CustomerID { get; set; }

        [StringLength(15)]
        public string CustomerSurname { get; set; }

        [StringLength(15)]
        public string CustomerName { get; set; }

        [StringLength(20)]
        public string CustomerPatronymic { get; set; }

        [StringLength(20)]
        public string CustomerPhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}

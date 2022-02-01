namespace Курорт.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            Requests = new HashSet<Requests>();
        }

        [Key]
        [StringLength(15)]
        public string Login { get; set; }

        [StringLength(15)]
        public string Password { get; set; }

        [StringLength(15)]
        public string Surname { get; set; }

        [StringLength(15)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Patronymic { get; set; }

        [StringLength(2)]
        public string PostID { get; set; }

        [Column("Phone number")]
        [StringLength(20)]
        public string Phone_number { get; set; }

        public virtual Posts Posts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}

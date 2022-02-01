namespace Курорт.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HotelRooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HotelRooms()
        {
            Requests = new HashSet<Requests>();
        }

        [Key]
        [StringLength(3)]
        public string RoomID { get; set; }

        public int? HowManyPeople { get; set; }

        [Column(TypeName = "money")]
        public decimal? RoomPrice { get; set; }

        public bool? OccupiedOrFree { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}

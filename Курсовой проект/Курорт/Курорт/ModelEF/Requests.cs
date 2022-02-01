namespace Курорт.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requests
    {
        [Key]
        [StringLength(3)]
        public string RequestID { get; set; }

        [StringLength(15)]
        public string Login { get; set; }

        [StringLength(3)]
        public string CustomerID { get; set; }

        [StringLength(3)]
        public string RoomID { get; set; }

        [StringLength(2)]
        public string FoodTypeID { get; set; }

        [Column("Check-inDate")]
        public DateTime? Check_inDate { get; set; }

        public DateTime? EvictionDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalСost { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual FoodTypes FoodTypes { get; set; }

        public virtual HotelRooms HotelRooms { get; set; }
    }
}

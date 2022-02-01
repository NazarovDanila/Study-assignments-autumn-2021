using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Курорт.ModelEF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<FoodTypes> FoodTypes { get; set; }
        public virtual DbSet<HotelRooms> HotelRooms { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerSurname)
                .IsFixedLength();

            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerName)
                .IsFixedLength();

            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerPatronymic)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .Property(e => e.Patronymic)
                .IsFixedLength();

            modelBuilder.Entity<FoodTypes>()
                .Property(e => e.FoodTypeName)
                .IsFixedLength();

            modelBuilder.Entity<FoodTypes>()
                .Property(e => e.FoodTypePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HotelRooms>()
                .Property(e => e.RoomPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Posts>()
                .Property(e => e.PostName)
                .IsFixedLength();

            modelBuilder.Entity<Posts>()
                .Property(e => e.PostSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Requests>()
                .Property(e => e.TotalСost)
                .HasPrecision(19, 4);
        }
    }
}

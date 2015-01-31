using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;

namespace Simorgh.Models
{
    public class Reservation
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime checkInTime { get; set; }
        public DateTime checkOutTime { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<ReservationItem> ReservationItems { get; set; }
    }



    public class ReservationDbContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
    }

    public class ReservationItem
    {
        [Key]
        public int Id { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}

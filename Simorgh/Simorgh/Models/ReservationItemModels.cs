using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class ReservationItem
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ReservationItemId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual Hotel Hotel { get; set; }
    }

    public class ReservationItemDbContext : DbContext
    {
        public DbSet<ReservationItem> ReservationItems { get; set; }
    }

}
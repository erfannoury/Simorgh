using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.Ajax.Utilities;

namespace Simorgh.Models
{
    public class Reservation
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }

        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<ReservationItem> ReservationItems { get; set; }
    }

    public class ReservationDbContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
    }
}

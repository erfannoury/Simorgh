using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class City
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }

        [Required]
        public string CityName { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; } 


    }

    public class CityDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
    }
}
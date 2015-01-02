using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Simorgh.Models
{
    public class Hotel
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int ImageFolderId { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int CityIdCity { get; set; }
        
        [StringLength(500, ErrorMessage = "Address cannot be longer than 500 characters.")]
        public string Address { get; set; }

        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        
        public string Description { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int Star { get; set; }
    }

    public class HotelDBContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
    }
}
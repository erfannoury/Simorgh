using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Simorgh.Models
{
    public class Hotel
    {
        
        public int Id { get; set; }
        public int ImageFolderId { get; set; }

        [StringLength(60, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string Name { get; set; }
        
        public int CityIdCity { get; set; }
        
        [StringLength(500, ErrorMessage = "Address cannot be longer than 500 characters.")]
        public string Address { get; set; }

        public double Longitude { get; set; }
        public double Latitude { get; set; }
        
        public string Description { get; set; }

        public int Star { get; set; }
    }

    public class HotelDBContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
    }
}
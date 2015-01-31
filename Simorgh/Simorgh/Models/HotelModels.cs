using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;

namespace Simorgh.Models
{
    public class Hotel
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // This is an internal property.
        public List<int> ImageIdList { get; set; }

        public string ImageIds { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "نام هتل حداکثر می‌تواند 60 کاراکتر باشد.")]
        public string Name { get; set; }

        // This is an internal property.
        [Range(0, double.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int CityId { get; set; }


        [StringLength(1000, ErrorMessage = "آدرس نمی‌تواند طولانی‌تر از 1000 کاراکتر باشد.")]
        public string Address { get; set; }


        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        public string Description { get; set; }

        // there shouldn't be a numeric input for this property. Using proper UI elements, users should score hotels.
        [Range(0, 5, ErrorMessage = "تعداد ستاره‌ها نمی‌تواند بیشتر از 5 عدد باشد.")]
        public int Star { get; set; }

        public string PhoneNumber { get; set; }

        public List<RoomType> RoomTypes { get; set; }

        // amenity: a desirable or useful feature or facility of a building or place
        public List<string> HotelAmenities { get; set; }

        public Hotel()
        {
            ImageIdList = new List<int>();
            RoomTypes = new List<RoomType>();
        }

    }



    public class HotelDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class Rating
    {
        public int RatingId { get; set; }

        public int TravellerUserId { get; set; }

        public int HotelId { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int StaffBehaviour { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int RoomCleanliness { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int OutdoorCleanliness { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int Prestige { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int FoodQuality { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int EnvironmentQuality { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int PriceQualityRatio { get; set; }

        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int Overall { get; set; }

        [StringLength(500, ErrorMessage = "Review cannot be longer than 500 characters.")]
        public String HotelReview { get; set; }
    }

    public class RatingDbContext : DbContext
    {
        public DbSet<Rating> Ratings { get; set; }
    }
}
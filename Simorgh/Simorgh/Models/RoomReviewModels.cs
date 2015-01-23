using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class RoomReview
    {

        public int RoomReviewId { get; set; }

        public int TravellerUserId { get; set; }

        public int RoomTypeId { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Review cannot be longer than 500 characters.")]
        public string Review { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be at least 0")]
        public int RateUp { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be at least 0")]
        public int RateDown { get; set; }

        public Boolean IsConfirmed { get; set; }
    }

    public class RoomReviewDbContext : DbContext
    {
        public DbSet<RoomReview> RoomReviews { get; set; }
    }
}
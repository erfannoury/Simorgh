using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class RoomType
    {
        //[Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RoomTypeId { get; set; }

        public int HotelId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int ImageFolderId { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Title cannot be longer than 60 characters.")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be at least 0")]
        public int RoomCapacity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be at least 0")]
        public int TotalCount { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be at least 0")]
        public int VacantCount { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The value must be at least 0")]
        public int Price { get; set; }

    }

    public class RoomTypeDBContext : DbContext
    {
        public DbSet<RoomType> RoomTypes { get; set; }
    }
}
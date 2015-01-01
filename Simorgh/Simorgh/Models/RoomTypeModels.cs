using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class RoomType
    {
        public int HotelId { get; set; }
        public int Id { get; set; }
        public int ImageFolderId { get; set; }

        [StringLength(60, ErrorMessage = "Title cannot be longer than 60 characters.")]
        public string Title { get; set; }

        public string Description { get; set; }
        
        public int RoomCapacity { get; set; }
        public int TotalCount { get; set; }
        public int VacantCount { get; set; }
        public int Price { get; set; }

    }

    public class RoomTypeDBContext : DbContext
    {
        public DbSet<RoomType> Hotels { get; set; }
    }
}
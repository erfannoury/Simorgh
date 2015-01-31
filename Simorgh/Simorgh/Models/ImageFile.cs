using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class ImageFile
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageFileId { get; set; }
        public string ImageFileLocation { get; set; }

        public int? HotelId { get; set; }
        public virtual Hotel ImageFileHotel { get; set; }

        public int? RoomTypeId { get; set; }
        public virtual RoomType ImageFileRoomType { get; set; }
    }

    public class ImageFileDbContext : DbContext
    {
        public DbSet<ImageFile> ImageFiles { get; set; }
    }
}
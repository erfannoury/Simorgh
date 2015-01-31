//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simorgh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomType
    {
        public RoomType()
        {
            this.ImageFiles = new HashSet<ImageFile>();
            this.Reservations = new HashSet<Reservation>();
            this.RoomReviews = new HashSet<RoomReview>();
        }
    
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomTypeDescription { get; set; }
        public int RoomCapacity { get; set; }
        public long Price { get; set; }
        public int HotelId { get; set; }
    
        public virtual Hotel Hotels { get; set; }
        public virtual ICollection<ImageFile> ImageFiles { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<RoomReview> RoomReviews { get; set; }
    }
}
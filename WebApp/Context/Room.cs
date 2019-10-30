namespace WebApp
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room() { Booking = new HashSet<Booking>(); }

        public int Id { get; set; }

        public int? HotelId { get; set; }

        public int? Number { get; set; }

        public int? Price { get; set; }

        [Required]
        [StringLength(25)]
        public string RoomType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}

namespace WebApp
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Booking")]
    public partial class Booking
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? RoomId { get; set; }

        [Column(TypeName = "date")]
        public System.DateTime? DateBegin { get; set; }

        [Column(TypeName = "date")]
        public System.DateTime? DateEnd { get; set; }

        public virtual User User { get; set; }

        public virtual Room Room { get; set; }
    }
}

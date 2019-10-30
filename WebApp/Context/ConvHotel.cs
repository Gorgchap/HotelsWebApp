namespace WebApp
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ConvHotel")]
    public partial class ConvHotel
    {
        public int Id { get; set; }

        public int? ConvId { get; set; }

        public int? HotelId { get; set; }

        public virtual Convenience Convenience { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}

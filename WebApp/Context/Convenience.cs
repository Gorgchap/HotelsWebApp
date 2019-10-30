namespace WebApp
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Convenience")]
    public partial class Convenience
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Convenience() { ConvHotel = new HashSet<ConvHotel>(); }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ConvName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConvHotel> ConvHotel { get; set; }
    }
}

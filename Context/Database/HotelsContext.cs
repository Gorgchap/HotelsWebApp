namespace Context
{
    using System.Data.Entity;
    public partial class HotelsContext : DbContext
    {
        public HotelsContext() : base("name=HotelsContext") { }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Convenience> Convenience { get; set; }
        public virtual DbSet<ConvHotel> ConvHotel { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<User> User { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Convenience>().Property(e => e.ConvName).IsUnicode(false);
            builder.Entity<Convenience>().HasMany(e => e.ConvHotel).WithOptional(e => e.Convenience).HasForeignKey(e => e.ConvId);
            builder.Entity<Hotel>().Property(e => e.Name).IsUnicode(false);
            builder.Entity<Hotel>().Property(e => e.City).IsUnicode(false);
            builder.Entity<Hotel>().Property(e => e.Address).IsUnicode(false);
            builder.Entity<Role>().Property(e => e.Name).IsUnicode(false);
            builder.Entity<Room>().Property(e => e.RoomType).IsUnicode(false);
            builder.Entity<User>().Property(e => e.Login).IsUnicode(false);
            builder.Entity<User>().Property(e => e.PasswordHash).IsUnicode(false);
            builder.Entity<User>().Property(e => e.Name).IsUnicode(false);
            builder.Entity<User>().Property(e => e.Surname).IsUnicode(false);
            builder.Entity<User>().Property(e => e.Email).IsUnicode(false);
            builder.Entity<User>().Property(e => e.Phone).IsUnicode(false);
        }
    }
}

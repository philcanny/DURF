namespace DesignUrFixie
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DURF : DbContext
    {
        public DURF()
            : base("name=DURF")
        {
        }

        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer1> Customers1 { get; set; }
        public virtual DbSet<Frame> Frames { get; set; }
        public virtual DbSet<Handlebar> Handlebars { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Saddle> Saddles { get; set; }
        public virtual DbSet<Wheel> Wheels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Bike)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer1>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Frame>()
                .Property(e => e.FrameColour)
                .IsFixedLength();

            modelBuilder.Entity<Frame>()
                .Property(e => e.FramePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Handlebar>()
                .Property(e => e.HandlebarColour)
                .IsFixedLength();

            modelBuilder.Entity<Handlebar>()
                .Property(e => e.HandlebarPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Saddle>()
                .Property(e => e.SaddleColour)
                .IsFixedLength();

            modelBuilder.Entity<Saddle>()
                .Property(e => e.SaddlePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Wheel>()
                .Property(e => e.WheelColour)
                .IsFixedLength();

            modelBuilder.Entity<Wheel>()
                .Property(e => e.WheelPrice)
                .HasPrecision(10, 2);
        }
    }
}

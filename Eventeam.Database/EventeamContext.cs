using System.Data.Entity;
using Eventeam.Database.Models;

namespace Eventeam.Database
{
    public class EventeamContext : DbContext
    {
        static EventeamContext()
        {
            System.Data.Entity.Database.SetInitializer<EventeamContext>(null);
        }

        // TODO: Investigate parameter 'MultipleActiveResultSets' in connection string
        public EventeamContext() : base()
        {
        }

        public EventeamContext(string connectionName) : base(connectionName)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<HotelCategory> HotelCategories { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomCategory> RoomCategories { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<NonStandardType> NonStandardTypes { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
        public virtual DbSet<Format> Formats { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<RestaurantType> RestaurantTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
              .HasMany(e => e.Platforms)
              .WithRequired(e => e.City)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.Platforms)
                .WithRequired(e => e.Level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Platforms)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Platform>()
                .HasMany(e => e.Halls)
                .WithRequired(e => e.Platform)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Platform>()
                .HasMany(e => e.Hotels)
                .WithRequired(e => e.Platform)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Platform>()
                .HasMany(e => e.Restaurants)
                .WithRequired(e => e.Platform)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Hotel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomCategory>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.RoomCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomType>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.RoomType)
                .HasForeignKey(e => e.RoomTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Format>()
                .HasMany(e => e.Portfolios)
                .WithRequired(e => e.Format)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kitchen>()
                .HasMany(e => e.Restaurants)
                .WithRequired(e => e.Kitchen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantType>()
                .HasMany(e => e.Restaurants)
                .WithRequired(e => e.RestaurantType)
                .WillCascadeOnDelete(false);
        }
    }
}
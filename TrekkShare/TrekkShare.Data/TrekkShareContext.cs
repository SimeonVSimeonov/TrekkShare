namespace TrekkShare.Data
{
    using Microsoft.EntityFrameworkCore;

    using EntityConfiguration;
    using TrekkShare.Models;

    public class TrekkShareContext : DbContext
    {
        public TrekkShareContext()
        {

        }

        public TrekkShareContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cave> Caves { get; set; }
        public DbSet<Cottage> Cottages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dam> Dams { get; set; }
        public DbSet<DamRiver> DamRivers { get; set; }
        public DbSet<GeoLocation> GeoLocations { get; set; }
        public DbSet<Lake> Lakes { get; set; }
        public DbSet<Monastery> Monasteries { get; set; }
        public DbSet<Mountain> Mountains { get; set; }
        public DbSet<MountainRiver> MountainRivers { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Peak> Peaks { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<River> Rivers { get; set; }
        public DbSet<RiverCountry> RiverCountries { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteMountain> RouteMountains { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<TouristTrip> TouristTrips { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Waterfall> Waterfalls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString,
                        sqlOptions => sqlOptions.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //missing MonasteryConfig, GeoLocationConfig
            modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new CaveConfig());
            modelBuilder.ApplyConfiguration(new CottageConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new DamConfig());
            modelBuilder.ApplyConfiguration(new DamRiverConfig());
            modelBuilder.ApplyConfiguration(new LakeConfig());   
            modelBuilder.ApplyConfiguration(new MountainConfig());
            modelBuilder.ApplyConfiguration(new MountainRiverConfig());
            modelBuilder.ApplyConfiguration(new MunicipalityConfig());
            modelBuilder.ApplyConfiguration(new PeakConfig());
            modelBuilder.ApplyConfiguration(new ProvinceConfig());
            modelBuilder.ApplyConfiguration(new RiverConfig());
            modelBuilder.ApplyConfiguration(new RiverCountryConfig());
            modelBuilder.ApplyConfiguration(new RouteConfig());
            modelBuilder.ApplyConfiguration(new RouteMountainConfig());
            modelBuilder.ApplyConfiguration(new TouristConfig());
            modelBuilder.ApplyConfiguration(new TouristTripConfig());
            modelBuilder.ApplyConfiguration(new TownConfig());
            modelBuilder.ApplyConfiguration(new TransportConfig());
            modelBuilder.ApplyConfiguration(new TripConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new WaterfallConfig());
        }
    }
}

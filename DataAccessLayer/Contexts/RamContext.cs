using Microsoft.EntityFrameworkCore;
using CourseProjectBlazor.DataAccessLayer.Models.RamModels;

namespace CourseProjectBlazor.DataAccessLayer.Contexts
{
    public class RamContext : DbContext
    {
        public RamContext() : base() 
        { 
        }
        public RamContext(DbContextOptions<RamContext> options) : base(options) { }

        public DbSet<Ram> Rams { get; set; }
        public DbSet<Cooling> RamCoolings { get; set; }
        public DbSet<FormFactor> RamFormFactors { get; set; }
        public DbSet<Manufacturer> RamManufacturers { get; set; }
        public DbSet<Type> RamTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // Ram configuration
            mb.Entity<Ram>().ToTable("Ram");
            mb.Entity<Ram>()
                .HasOne(rr => rr.Cooling)
                .WithMany(rc => rc.Rams);
            mb.Entity<Ram>()
                .HasOne(rr => rr.FormFactor)
                .WithMany(rff => rff.Rams);
            mb.Entity<Ram>()
                .HasOne(rr => rr.Manufacturer)
                .WithMany(rm => rm.Rams);
            mb.Entity<Ram>()
                .HasOne(rr => rr.Type)
                .WithMany(rt => rt.Rams);
            mb.Entity<Ram>().Property(rr => rr.Model).HasDefaultValue("");
            mb.Entity<Ram>().Property(rr => rr.ModuleAmount).HasDefaultValue(1);

            // Ram cooling configuration
            mb.Entity<Cooling>().ToTable("RamCooling");
            mb.Entity<Cooling>().HasIndex(rc => rc.Name).IsUnique();
            mb.Entity<Cooling>()
                .Property(rc => rc.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Ram manufacturer configuration
            mb.Entity<Manufacturer>().ToTable("RamManufacturer");
            mb.Entity<Manufacturer>().HasIndex(rm => rm.Name).IsUnique();
            mb.Entity<Manufacturer>()
                .Property(rm => rm.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Ram type configuration
            mb.Entity<Type>().ToTable("RamType");
            mb.Entity<Type>().HasIndex(rt => rt.Name).IsUnique();
            mb.Entity<Type>()
                .Property(rt => rt.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Ram form factor configuration
            mb.Entity<FormFactor>().ToTable("RamFormFactor");
            mb.Entity<FormFactor>().HasIndex(rff => rff.Name).IsUnique();
            mb.Entity<FormFactor>()
                .Property(rff => rff.Name)
                .HasColumnType("TEXT COLLATE NOCASE");
        }
    }
}
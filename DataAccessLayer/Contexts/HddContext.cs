using Microsoft.EntityFrameworkCore;
using CourseProjectBlazor.DataAccessLayer.Models.HddModels;

namespace CourseProjectBlazor.DataAccessLayer.Contexts
{
    public class HddContext : DbContext
    {
        public HddContext() : base() 
        { 
        }
        public HddContext(DbContextOptions<HddContext> options) : base(options) { }

        public DbSet<Hdd> Hdds { get; set; }
        public DbSet<FormFactor> HddFormFactors { get; set; }
        public DbSet<Manufacturer> HddManufacturers { get; set; }
        public DbSet<Interface> HddTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // Hdd configuration
            mb.Entity<Hdd>().ToTable("Hdd");
            mb.Entity<Hdd>()
                .HasOne(hh => hh.FormFactor)
                .WithMany(hff => hff.Hdds);
            mb.Entity<Hdd>()
                .HasOne(hh => hh.Manufacturer)
                .WithMany(hm => hm.Hdds);
            mb.Entity<Hdd>()
                .HasOne(hh => hh.Interface)
                .WithMany(hi => hi.Hdds);
            mb.Entity<Hdd>().Property(hh => hh.Model).HasDefaultValue("");
            mb.Entity<Hdd>().Property(hh => hh.ManufacturerCode).HasDefaultValue("");

            // Hdd interface configuration
            mb.Entity<Interface>().ToTable("HddInterface");
            mb.Entity<Interface>().HasIndex(hi => hi.Name).IsUnique();
            mb.Entity<Interface>()
                .Property(hi => hi.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Hdd manufacturer configuration
            mb.Entity<Manufacturer>().ToTable("HddManufacturer");
            mb.Entity<Manufacturer>().HasIndex(hm => hm.Name).IsUnique();
            mb.Entity<Manufacturer>()
                .Property(hm => hm.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Hdd form factor configuration
            mb.Entity<FormFactor>().ToTable("HddFormFactor");
            mb.Entity<FormFactor>().HasIndex(hff => hff.Name).IsUnique();
            mb.Entity<FormFactor>()
                .Property(hff => hff.Name)
                .HasColumnType("TEXT COLLATE NOCASE");
        }
    }
}
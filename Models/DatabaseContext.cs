using System;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectBlazor.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base() 
        { 
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Ram.Ram> Rams { get; set; }
        public DbSet<Ram.Cooling> RamCoolings { get; set; }
        public DbSet<Ram.FormFactor> RamFormFactors { get; set; }
        public DbSet<Ram.Manufacturer> RamManufacturers { get; set; }
        public DbSet<Ram.Type> RamTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // Ram configuration
            mb.Entity<Ram.Ram>().ToTable("Ram");
            mb.Entity<Ram.Ram>()
                .HasOne(rr => rr.Cooling)
                .WithMany(rc => rc.Rams);
            mb.Entity<Ram.Ram>()
                .HasOne(rr => rr.FormFactor)
                .WithMany(rff => rff.Rams);
            mb.Entity<Ram.Ram>()
                .HasOne(rr => rr.Manufacturer)
                .WithMany(rm => rm.Rams);
            mb.Entity<Ram.Ram>()
                .HasOne(rr => rr.Type)
                .WithMany(rt => rt.Rams);
            mb.Entity<Ram.Ram>().Property(rr => rr.Model).HasDefaultValue("");
            mb.Entity<Ram.Ram>().Property(rr => rr.ModuleAmount).HasDefaultValue(1);

            // Ram cooling configuration
            mb.Entity<Ram.Cooling>().ToTable("RamCooling");
            mb.Entity<Ram.Cooling>().HasIndex(rc => rc.Name).IsUnique();
            mb.Entity<Ram.Cooling>()
                .Property(rc => rc.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Ram manufacturer configuration
            mb.Entity<Ram.Manufacturer>().ToTable("RamManufacturer");
            mb.Entity<Ram.Manufacturer>().HasIndex(rm => rm.Name).IsUnique();
            mb.Entity<Ram.Manufacturer>()
                .Property(rm => rm.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Ram type configuration
            mb.Entity<Ram.Type>().ToTable("RamType");
            mb.Entity<Ram.Type>().HasIndex(rt => rt.Name).IsUnique();
            mb.Entity<Ram.Type>()
                .Property(rt => rt.Name)
                .HasColumnType("TEXT COLLATE NOCASE");

            // Ram form factor configuration
            mb.Entity<Ram.FormFactor>().ToTable("RamFormFactor");
            mb.Entity<Ram.FormFactor>().HasIndex(rff => rff.Name).IsUnique();
            mb.Entity<Ram.FormFactor>()
                .Property(rff => rff.Name)
                .HasColumnType("TEXT COLLATE NOCASE");
        }
    }
}
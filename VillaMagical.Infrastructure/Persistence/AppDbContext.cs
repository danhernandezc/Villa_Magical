using Microsoft.EntityFrameworkCore;
using VillaMagical.Domain.Entities;

namespace VillaMagical.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>(entity =>
            {
                // =========================
                // Tabla
                // =========================
                entity.ToTable("Villa", "dbo");

                // =========================
                // Primary Key
                // =========================
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                // =========================
                // Name
                // =========================
                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasMaxLength(100)
                    .IsRequired();

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                // =========================
                // Occupancy
                // =========================
                entity.Property(e => e.Occupancy)
                    .HasColumnName("Occupancy")
                    .IsRequired();

                // =========================
                // Price (decimal 18,2)
                // =========================
                entity.Property(e => e.Price)
                    .HasColumnName("Price")
                    .HasPrecision(18, 2)
                    .IsRequired();

                // =========================
                // Avenue
                // =========================
                entity.Property(e => e.Avenue)
                    .HasColumnName("Avenue")
                    .HasMaxLength(200)
                    .IsRequired();

                // =========================
                // Details
                // =========================
                entity.Property(e => e.Detail)
                    .HasColumnName("Detail")
                    .HasMaxLength(200)
                    .IsRequired();

                // =========================
                // ImageUrl
                // =========================
                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageUrl")
                    .IsRequired();

                // =========================
                // CreatedDate
                // =========================
                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CreatedDate")
                    .IsRequired();

                // =========================
                // UpdatedDate
                // =========================
                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UpdatedDate");
            });


        }

    }
}

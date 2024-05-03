using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.IO;
using Microsoft.Extensions.Options;

namespace OOP_Kurs_Simakin
{
    public partial class kursContext : DbContext
    {
        public kursContext()
        {
        }

        public kursContext(DbContextOptions<kursContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Cuisine> Cuisines { get; set; } = null!;
        public virtual DbSet<Meal> Meals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "data.db");
                optionsBuilder.UseSqlite($"Data Source={path}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
            });

            modelBuilder.Entity<Cuisine>(entity =>
            {
                entity.ToTable("Cuisine");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.HasKey(e => e.IdMeal);

                entity.ToTable("Meal");

                entity.Property(e => e.IdMeal)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idMeal");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Cuisine)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.CuisineId);
            });

            OnModelCreatingPartial(modelBuilder); 
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

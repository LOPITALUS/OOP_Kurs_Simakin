using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
                optionsBuilder.UseSqlite("Data Source=E:\\\\\\\\Институт\\\\\\\\4 семестр\\\\\\\\Курсовой 4 семестр ООП\\\\\\\\db\\\\\\\\kurs.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("Category");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");
             //   entity.Property(e => e.IdCategory).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Cuisine>(entity =>
            {
                entity.HasKey(e => e.IdCuisine);

                entity.ToTable("Cuisine");

                entity.Property(e => e.IdCuisine).HasColumnName("idCuisine");
              //  entity.Property(e => e.IdCuisine).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.HasKey(e => e.IdMeal);

                entity.ToTable("Meal");

                entity.Property(e => e.IdMeal).HasColumnName("idMeal");
               // entity.Property(e => e.IdMeal).ValueGeneratedOnAdd();


                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.CuisineId).HasColumnName("Cuisine_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Cuisine)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.CuisineId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

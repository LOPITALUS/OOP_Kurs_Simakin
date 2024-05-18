using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.IO;
using Microsoft.Extensions.Options;

namespace OOP_Kurs_Simakin
{
    /// <summary>
    /// Класс контекста
    /// </summary>
    public partial class kursContext : DbContext
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public kursContext()
        {
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="options">Опции</param>
        public kursContext(DbContextOptions<kursContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Категории
        /// </summary>
        public virtual DbSet<Category> Categories { get; set; } = null!;

        /// <summary>
        /// Кухни
        /// </summary>
        public virtual DbSet<Cuisine> Cuisines { get; set; } = null!;

        /// <summary>
        /// Блюда
        /// </summary>
        public virtual DbSet<Meal> Meals { get; set; } = null!;

        /// <summary>
        /// Метод конфигурации
        /// </summary>
        /// <param name="optionsBuilder">Опции</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "data.db");
                optionsBuilder.UseSqlite($"Data Source={path}");
            }
        }

        /// <summary>
        /// Метод создания
        /// </summary>
        /// <param name="modelBuilder">Параметры</param>
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

        /// <summary>
        /// Метод частичного создания
        /// </summary>
        /// <param name="modelBuilder"></param>
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

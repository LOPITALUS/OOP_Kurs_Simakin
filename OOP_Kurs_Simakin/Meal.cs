using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_Kurs_Simakin
{   
    /// <summary>
    /// Класс блюда
    /// </summary>
    public partial class Meal
    {
        /// <summary>
        /// Идентификатор блюда
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdMeal { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = null!;
        
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Кол-во ккал
        /// </summary>
        public double Kcal { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Идентификатор категории блюда
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// Идентификатор кухни
        /// </summary>
        public long CuisineId { get; set; }

        /// <summary>
        /// Категория блюда
        /// </summary>
        public virtual Category Category { get; set; } = null!;

        /// <summary>
        /// Кухня
        /// </summary>
        public virtual Cuisine Cuisine { get; set; } = null!;
    }
}

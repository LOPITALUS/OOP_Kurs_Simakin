using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_Kurs_Simakin
{
    /// <summary>
    /// Класс кухни
    /// </summary>
    public partial class Cuisine
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Cuisine()
        {
            Meals = new HashSet<Meal>();
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="description">Описание</param>
        public Cuisine(string name, string description)
        {
            Name = name;
            Description = description;
            Meals = new HashSet<Meal>();
        }

        /// <summary>
        /// Идентификатор кухни
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CuisineId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Связанные сущности из таблицы "Блюда"
        /// </summary>
        public virtual ICollection<Meal> Meals { get; set; }

        /// <summary>
        /// Реализация ToString()
        /// </summary>
        /// <returns>Название</returns>
        public override string ToString() => Name;
    }
}

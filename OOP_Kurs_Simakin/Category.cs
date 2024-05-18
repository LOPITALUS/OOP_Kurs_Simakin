using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_Kurs_Simakin
{
    /// <summary>
    /// Класс категории блюд
    /// </summary>
    public partial class Category
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Category()
        {
            Meals = new HashSet<Meal>();
        }

        /// <summary>
        /// Конструкутор с параметрами
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="description">Описание</param>
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
            Meals = new HashSet<Meal>();
        }

        /// <summary>
        /// Идентификатор категории
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryId { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Описание категории
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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_Kurs_Simakin
{
    public partial class Category
    {
        public Category()
        {
            Meals = new HashSet<Meal>();
        }

        public Category(string name)
        {
            Name = name;
        }

        [Key]
        public string Name { get; set; } = null!;

        public virtual ICollection<Meal> Meals { get; set; }
    }
}

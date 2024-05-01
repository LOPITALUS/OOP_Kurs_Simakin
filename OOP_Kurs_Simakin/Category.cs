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

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }

        public override string ToString() => Name;
    }
}

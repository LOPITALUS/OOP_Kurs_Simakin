using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OOP_Kurs_Simakin
{
    public partial class Cuisine
    {
        public Cuisine()
        {
            Meals = new HashSet<Meal>();
        }

        public Cuisine(string name, string description)
        {
            Name = name;
            Description = description;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CuisineId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}

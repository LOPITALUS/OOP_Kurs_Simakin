using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_Kurs_Simakin
{
    public partial class Cuisine
    {
        public Cuisine()
        {
            Meals = new HashSet<Meal>();
        }

        public Cuisine(string name)
        {
            Name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdCuisine { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Meal> Meals { get; set; }
    }
}

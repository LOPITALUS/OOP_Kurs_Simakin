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

        public Cuisine(string name, string descriprion)
        {
            Name = name;
            Description = descriprion; 
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CuisineId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }

        public override string ToString() => Name;
    }
}

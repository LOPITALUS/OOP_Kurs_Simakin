using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_Kurs_Simakin
{
    public partial class Meal
    {

        public Meal(string name, double weight, double kcal, double price) { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdMeal { get; set; }
        public string Name { get; set; } = null!;
        public double Weight { get; set; }
        public double Kcal { get; set; }
        public double Price { get; set; }

        [ForeignKey("CuisineId")]
        public long CuisineId { get; set; }

        [ForeignKey("CategoryId")]
        public long CategoryId { get; set; }

        
   public virtual Category Category { get; set; } = null!;

        
      public virtual Cuisine Cuisine { get; set; } = null!;
    }
}

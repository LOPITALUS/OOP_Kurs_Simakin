using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OOP_Kurs_Simakin
{
    public partial class Meal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdMeal { get; set; }
        public string Name { get; set; } = null!;
        public double Weight { get; set; }
        public double Kcal { get; set; }
        public double Price { get; set; }
        [ForeignKey("CategoryId")]
        public long CategoryId { get; set; }
        [ForeignKey("CuisineId")]
        public long CuisineId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Cuisine Cuisine { get; set; } = null!;
    }
}

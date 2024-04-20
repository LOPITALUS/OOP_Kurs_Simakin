using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_Kurs_Simakin
{
    public partial class Meal
    {
        public Meal(string name, double weight, double kcal, double price, Category cat, Cuisine cuis) { 
            Name = name;
            Weight = weight;    
            Kcal = kcal;
            Price = price;
            Category = cat;
            Cuisine = cuis;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdMeal { get; set; }
        public string Name { get; set; } = null!;
        public double Weight { get; set; }
        public double Kcal { get; set; }
        public double Price { get; set; }

        public long CategoryId { get; set; }
        public long CuisineId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Cuisine Cuisine { get; set; } = null!;
    }
}

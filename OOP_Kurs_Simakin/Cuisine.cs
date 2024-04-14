using System;
using System.Collections.Generic;

namespace OOP_Kurs_Simakin
{
    public partial class Cuisine
    {
        public Cuisine()
        {
            Meals = new HashSet<Meal>();
        }

        public long IdCuisine { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Meal> Meals { get; set; }
    }
}

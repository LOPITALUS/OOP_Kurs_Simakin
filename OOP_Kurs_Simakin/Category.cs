using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace OOP_Kurs_Simakin
{
    public partial class Category
    {
        public Category()
        {
            Meals = new HashSet<Meal>();
        }

        public Category(long idCategory, string name)
        {
            IdCategory = idCategory;
            Name = name;
        }

        [Key]

        public long IdCategory { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Meal> Meals { get; set; }
    }
}

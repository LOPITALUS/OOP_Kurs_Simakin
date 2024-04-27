using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurs_Simakin
{
    public partial class AddMealForm : Form
    {

        public AddMealForm(MealForm meal_form)
        {
            InitializeComponent();
            ref_to_parent_form = meal_form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyAddMealForm_Click(object sender, EventArgs e)
        {
            string name = NewMealName.Text;
            int weight = (int)NewMealWeight.Value;
            int kcal = (int)NewMealKcal.Value;
            int price = (int)NewMealPrice.Value;
            string cuisine = Cuisines.Text;
            string category = Categories.Text;
            
            using (kursContext db = new kursContext())
            {
                Cuisine cuis = db.Cuisines.First(c => c.Name == cuisine);
                Category cat = db.Categories.First(c => c.Name == category);
                Meal new_meal = new Meal {Name = name, Weight = weight, Kcal = kcal, Price = price, Category = cat, Cuisine = cuis };
                db.Meals.Add(new_meal);
                db.SaveChanges();
                long id = new_meal.CuisineId;              
                ref_to_parent_form.MealsTable.Rows.Add(new_meal.Name, new_meal.Weight, new_meal.Kcal, new_meal.Price, new_meal.CuisineId, new_meal.CategoryId);
            }
        }

        private void AddMealForm_Load(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                var cuisines = db.Cuisines.Select(c => c.Name).ToList();
                foreach (var c in cuisines)
                {
                    Cuisines.Items.Add(c);
                }

                var categoties = db.Categories.Select(c => c.Name).ToList();
                foreach (var c in categoties)
                {
                    Categories.Items.Add(c);
                }
            }
        }

        private MealForm ref_to_parent_form;
    }
}

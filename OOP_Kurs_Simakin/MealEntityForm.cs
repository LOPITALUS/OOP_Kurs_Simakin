using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurs_Simakin
{

    public partial class MealEntityForm : Form
    {
        private long id;
        private MealForm ref_to_parent_form;
        public MealEntityForm(long _id, MealForm _ref_to_parent_form)
        {
            InitializeComponent();
            id = _id;
            ref_to_parent_form = _ref_to_parent_form;
        }

        private void ApplyChanges_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                Meal meal = db.Meals.First(e => e.IdMeal == id);
                meal.Name = EditedMealName.Text;
                meal.Weight = (int)EditedMealWeight.Value;
                meal.Kcal = (int)EditedMealKcal.Value;
                meal.Price = (int)EditedMealPrice.Value;
                Cuisine cuis = db.Cuisines.First(c => c.Name == EditedMealCuisines.Text);
                Category cat = db.Categories.First(c => c.Name == EditedMealCategories.Text);
                meal.Cuisine = cuis;
                meal.Category = cat;
                db.SaveChanges();
                UpdateDGV(meal);
            }
        }

        private void MealEntityForm_Load(object sender, EventArgs e)
        {
            Text = $"ID : {id}";
            using (kursContext db = new kursContext())
            {
                Meal meal = db.Meals.FirstOrDefault(e => e.IdMeal == id);
                EditedMealName.Text = meal.Name;
                EditedMealWeight.Value = (int)meal.Weight;
                EditedMealKcal.Value = (int)meal.Kcal;
                EditedMealPrice.Value = (int)meal.Price;

                var cuisines = db.Cuisines.Select(c => c.Name).ToList();
                foreach (var c in cuisines)
                {
                    EditedMealCuisines.Items.Add(c);
                }

                var categoties = db.Categories.Select(c => c.Name).ToList();
                foreach (var c in categoties)
                {
                    EditedMealCategories.Items.Add(c);
                }

                EditedMealCuisines.SelectedItem = db.Cuisines.FirstOrDefault(c => c.CuisineId == meal.CuisineId).ToString();

                EditedMealCategories.SelectedItem = db.Categories.FirstOrDefault(c => c.CategoryId == meal.CategoryId).ToString();
            }
        }

        private void UpdateDGV(Meal edited_meal)
        {
            for (int i = 0; i<ref_to_parent_form.MealsTable.RowCount; i++)
            {
                if ((long)ref_to_parent_form.MealsTable.Rows[i].Cells[0].Value == id)
                {
                    ref_to_parent_form.MealsTable.Rows[i].Cells[1].Value = edited_meal.Name;
                    ref_to_parent_form.MealsTable.Rows[i].Cells[2].Value = edited_meal.Weight;
                    ref_to_parent_form.MealsTable.Rows[i].Cells[3].Value = edited_meal.Kcal;
                    ref_to_parent_form.MealsTable.Rows[i].Cells[4].Value = edited_meal.Price;
                    ref_to_parent_form.MealsTable.Rows[i].Cells[5].Value = edited_meal.CuisineId;
                    ref_to_parent_form.MealsTable.Rows[i].Cells[6].Value = edited_meal.CategoryId;
                    return;
                }
            }
        }
    }
}

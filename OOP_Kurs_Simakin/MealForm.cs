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
    public partial class MealForm : Form
    {
        public MealForm()
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            InitializeComponent();
        }

        private void MealForm_Load(object sender, EventArgs e)
        {
            UpdateMealsDGV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Открытие окна добаления
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMealForm addMealForm = new AddMealForm(this);
            addMealForm.ShowDialog();
        }

        private void AddNewCuisine_Click(object sender, EventArgs e)
        {
            CuisineForm сuisineForm = new CuisineForm();
            сuisineForm.ShowDialog();
        }

        private void AddNewCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(this);
            addCategoryForm.ShowDialog();
        }

        public void UpdateMealsDGV()
        {
            using (kursContext db = new kursContext())
            {
                var meals = db.Meals.ToList();
                foreach (var meal in meals)
                {
                    MealsTable.Rows.Add(meal.Name, meal.Weight, meal.Kcal, meal.Price, meal.CuisineId, meal.CategoryId);
                }
            }
        }

        private void SetFiltersButton_Click(object sender, EventArgs e)
        {
            MealsTable.Rows.Clear();
            using (kursContext db = new kursContext())
            {
                var meals = db.Meals.OrderBy(e => e.Price).ToList();
                foreach (var meal in meals)
                {
                    MealsTable.Rows.Add(meal.Name, meal.Weight, meal.Kcal, meal.Price, meal.CuisineId, meal.CategoryId);
                }
            }
        }
    }
}

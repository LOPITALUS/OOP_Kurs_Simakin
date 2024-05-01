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
            ResetMealsDGV();
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

        public void ResetMealsDGV()
        {
            MealsTable.Rows.Clear();
            using (kursContext db = new kursContext())
            {
                var meals = db.Meals.ToList();
                foreach (var meal in meals)
                {
                    MealsTable.Rows.Add(meal.IdMeal, meal.Name, meal.Weight, meal.Kcal, meal.Price, meal.CuisineId, meal.CategoryId);
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
                    MealsTable.Rows.Add(meal.IdMeal, meal.Name, meal.Weight, meal.Kcal, meal.Price, meal.CuisineId, meal.CategoryId);
                }
            }
        }

        private void MealsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long current_id = (long)MealsTable.Rows[e.RowIndex].Cells[0].Value;
            MealEntityForm mef = new MealEntityForm(current_id, this);
            mef.ShowDialog();
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            MealsTable.Rows.Clear();
            string current_name = NameForSearching.Text;
            using (kursContext db = new kursContext())
            {
                var meals = db.Meals.ToList();
                foreach (var meal in meals)
                {
                    if (meal.Name == current_name)
                        MealsTable.Rows.Add(meal.IdMeal, meal.Name, meal.Weight, meal.Kcal, meal.Price, meal.CuisineId, meal.CategoryId);
                }
            }
        }

        private void SearchIdButton_Click(object sender, EventArgs e)
        {
            long current_id = (long)IdForSearching.Value;
            using (kursContext db = new kursContext())
            {
                if (db.Meals.FirstOrDefault(c => c.IdMeal == current_id) != null)
                {
                    MealEntityForm mef = new MealEntityForm(current_id, this);
                    mef.ShowDialog();
                }
                // else cout не существует
            }
        }

        private void CancelFilters_Click(object sender, EventArgs e)
        {
            ResetMealsDGV();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                if (IdSort.Checked)
                {
                    MealsTable.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[2], ListSortDirection.Ascending);
                    /*IOrderedQueryable<Meal> sorted = db.Meals.OrderBy(e => e.Price);
                    db.Meals.RemoveRange(db.Meals);
                    db.Meals.AddRange(sorted);
                    db.SaveChanges();*/
                    //sorted.ThenBy(e => e.Kcal);
                    //sorted.ToList();

                    //MealsTable.Rows.Clear();
                    //var meals = sorted.ToList();
                    //foreach (var meal in meals)
                    //{
                    //    MealsTable.Rows.Add(meal.IdMeal, meal.Name, meal.Weight, meal.Kcal, meal.Price, meal.CuisineId, meal.CategoryId);
                    //}
                }




            }
        }
    }
}

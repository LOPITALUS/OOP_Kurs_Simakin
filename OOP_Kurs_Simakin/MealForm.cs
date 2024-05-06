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
            using (kursContext db = new kursContext())
            {
                db.Database.EnsureCreated();
            }
            ResetMealsDGV();
        }

        private void CreateDb_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                if (db.Database.EnsureCreated())
                    MessageBox.Show("База данных успешно создана!", "Уведомление");
                else
                    MessageBox.Show("База данных уже существует!", "Уведомление");
            }
        }

        private void DeleteDb_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                if (db.Database.EnsureDeleted())
                    MessageBox.Show("База данных успешно удалена!", "Уведомление");
                else
                    MessageBox.Show("База данных не существовало!", "Уведомление");
            }
            MealsTable.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMealForm addMealForm = new AddMealForm(this);
            addMealForm.ShowDialog();
        }

        private void OpenCategoryForm_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void OpenCuisineForm_Click(object sender, EventArgs e)
        {
            CuisineForm cuisineForm = new CuisineForm();
            cuisineForm.ShowDialog();
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
            double min_w = (double)WeightFilterMin.Value;
            double max_w = (double)WeightFilterMax.Value;

            double min_k = (double)KcalFilterMin.Value;
            double max_k = (double)KcalFilterMax.Value;

            double min_p = (double)PriceFilterMin.Value;
            double max_p = (double)PriceFilterMax.Value;

            using (kursContext db = new kursContext())
            {
                var meals = db.Meals.ToList();
                foreach (var meal in meals)
                {
                    if ((meal.Weight >= min_w && meal.Weight <= max_w) && (meal.Kcal >= min_k && meal.Kcal <= max_k) && (meal.Price >= min_p && meal.Price <= max_p))
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
                else
                    MessageBox.Show("По данному ID нет записей", "Уведомление");
            }
        }

        private void CancelFilters_Click(object sender, EventArgs e)
        {
            ResetMealsDGV();
            MessageBox.Show("Все фильтры сняты\nТаблица показывает актуальную таблицу из БД", "Уведомление");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                var direction = (UpSort.Checked) ? ListSortDirection.Ascending : ListSortDirection.Descending;

                if (IdSort.Checked)
                {
                    MealsTable.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[0], direction);
                }
                if (NameSort.Checked)
                {
                    MealsTable.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[1], direction);
                }
                if (WeightSort.Checked)
                {
                    MealsTable.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[2], direction);
                }
                if (KcalSort.Checked)
                {
                    MealsTable.Columns[3].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[3], direction);
                }
                if (PriceSort.Checked)
                {
                    MealsTable.Columns[4].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[4], direction);
                }
                if (CuisineSort.Checked)
                {
                    MealsTable.Columns[5].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[5], direction);
                }
                if (CategorySort.Checked)
                {
                    MealsTable.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
                    MealsTable.Sort(MealsTable.Columns[6], direction);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WeightFilterMin_ValueChanged(object sender, EventArgs e)
        {
            WeightFilterMax.Minimum = WeightFilterMin.Value;
        }

        private void KcalFilterMin_ValueChanged(object sender, EventArgs e)
        {
            KcalFilterMax.Minimum = KcalFilterMin.Value;
        }

        private void PriceFilterMin_ValueChanged(object sender, EventArgs e)
        {
            PriceFilterMax.Minimum = PriceFilterMin.Value;
        }
    }
}


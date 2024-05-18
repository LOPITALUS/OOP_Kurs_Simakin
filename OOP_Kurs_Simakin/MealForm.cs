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
    /// <summary>
    /// Окно "Меню"
    /// </summary>
    public partial class MealForm : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public MealForm()
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            InitializeComponent();
        }

        /// <summary>
        /// Заполнение таблицы при загрузке
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void MealForm_Load(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                db.Database.EnsureCreated();
            }
            ResetMealsDGV();
        }

        /// <summary>
        /// Создать базу данных
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CreateDb_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                if (db.Database.EnsureCreated())
                    MessageBox.Show("База данных успешно создана!", "Уведомление");
                else
                    MessageBox.Show("База данных уже существует!", "Уведомление");
            }
            EnableButtons(true);
        }

        /// <summary>
        /// Удалить базу данных
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void DeleteDb_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                if (db.Database.EnsureDeleted())
                    MessageBox.Show("База данных успешно удалена!", "Уведомление");
                else
                    return;
            }
            MealsTable.Rows.Clear();
            EnableButtons(false);
        }

        /// <summary>
        /// Перейти в окно добавления нового блюда
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void button3_Click(object sender, EventArgs e)
        {
            AddMealForm addMealForm = new AddMealForm(this);
            addMealForm.ShowDialog();
        }

        /// <summary>
        /// Открыть окно "Категории блюд"
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void OpenCategoryForm_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(this);
            categoryForm.ShowDialog();
        }

        /// <summary>
        /// Открыть окно "Виды кухонь"
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void OpenCuisineForm_Click(object sender, EventArgs e)
        {
            CuisineForm cuisineForm = new CuisineForm(this);
            cuisineForm.ShowDialog();
        }

        /// <summary>
        /// Перестроить таблицу 
        /// </summary>
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

        /// <summary>
        /// Установить фильтры
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
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

        /// <summary>
        /// Поиск по имени
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
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

        /// <summary>
        /// Поиск по идентификатору
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
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

        /// <summary>
        /// Снять все фильтры с таблицы
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CancelFilters_Click(object sender, EventArgs e)
        {
            ResetMealsDGV();
            MessageBox.Show("Все фильтры сняты\nТаблица показывает актуальную таблицу из БД", "Уведомление");
        }

        /// <summary>
        /// Запустить сортировку
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
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

        /// <summary>
        /// Закрыть окно
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Изменение минимального значения фильтра (Вес)
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void WeightFilterMin_ValueChanged(object sender, EventArgs e)
        {
            WeightFilterMax.Minimum = WeightFilterMin.Value;
        }

        /// <summary>
        /// Изменение минимального значения фильтра (Кол-во ккал)
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void KcalFilterMin_ValueChanged(object sender, EventArgs e)
        {
            KcalFilterMax.Minimum = KcalFilterMin.Value;
        }

        /// <summary>
        /// Изменение минимального значения фильтра (Цена)
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void PriceFilterMin_ValueChanged(object sender, EventArgs e)
        {
            PriceFilterMax.Minimum = PriceFilterMin.Value;
        }

        /// <summary>
        /// Открытие окна представления записи при клике на строкуу таблицы
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void MealsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long current_id = (long)MealsTable.Rows[e.RowIndex].Cells[0].Value;
                MealEntityForm mef = new MealEntityForm(current_id, this);
                mef.ShowDialog();
            }
        }

        /// <summary>
        /// Изменить активность кнопок (кроме "Создать БД")
        /// </summary>
        /// <param name="enable">Сделать активными</param>
        private void EnableButtons(bool enable)
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                    c.Enabled = enable;
            }
            foreach (Control c in SortPanel.Controls)
            {
                if (c is Button)
                    c.Enabled = enable;
            }
            foreach (Control c in FiltersPanel.Controls)
            {
                if (c is Button)
                    c.Enabled = enable;
            }
            foreach (Control c in SearchPanel.Controls)
            {
                if (c is Button)
                    c.Enabled = enable;
            }
            if (!enable)
                CreateDb.Enabled = true;
        }

        
    }
}


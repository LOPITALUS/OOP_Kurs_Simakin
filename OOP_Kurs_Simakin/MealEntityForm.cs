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
    /// Окно представления блюда
    /// </summary>
    public partial class MealEntityForm : Form
    {
        /// <summary>
        /// Идентификатор открытой записи
        /// </summary>
        private long id;

        /// <summary>
        /// Ссылка на окно "Меню"
        /// </summary>
        private MealForm ref_to_parent_form;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_id">Идентификатор открытой записи</param>
        /// <param name="_ref_to_parent_form">Ссылка на окно "Меню"</param>
        public MealEntityForm(long _id, MealForm _ref_to_parent_form)
        {
            InitializeComponent();
            id = _id;
            ref_to_parent_form = _ref_to_parent_form;
        }

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ApplyChanges_Click(object sender, EventArgs e)
        {
            string name = EditedMealName.Text;
            double weight = (double)EditedMealWeight.Value;
            double kcal = (double)EditedMealKcal.Value;
            double price = (double)EditedMealPrice.Value;
            long cuisine_id = (long)CuisineId.Value;
            long category_id = (long)CategoryId.Value;

            if (name.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление");
                return;
            }

            using (kursContext db = new kursContext())
            {
                Meal meal = db.Meals.First(e => e.IdMeal == id);
                meal.Name = name;
                meal.Weight = weight;
                meal.Kcal = kcal;
                meal.Price = price;
                Cuisine cuis = db.Cuisines.FirstOrDefault(c => c.CuisineId == cuisine_id);
                Category cat = db.Categories.FirstOrDefault(c => c.CategoryId == category_id);
                if (cuis == null)
                {
                    MessageBox.Show("Вида кухни с заданным ID не существует", "Уведомление");
                    return;
                }
                if (cat == null)
                {
                    MessageBox.Show("Категории блюд с заданным ID не существует", "Уведомление");
                    return;
                }
                meal.Cuisine = cuis;
                meal.Category = cat;
                db.SaveChanges();
                UpdateDGV(meal);
            }
        }

        /// <summary>
        /// Заполнить информацию о записи при загрузке
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void MealEntityForm_Load(object sender, EventArgs e)
        {
            Text = $"ID : {id}";
            using (kursContext db = new kursContext())
            {
                Meal meal = db.Meals.FirstOrDefault(e => e.IdMeal == id);
                EditedMealName.Text = meal.Name;
                EditedMealWeight.Value = (decimal)meal.Weight;
                EditedMealKcal.Value = (decimal)meal.Kcal;
                EditedMealPrice.Value = (decimal)meal.Price;
                CuisineId.Value = meal.CuisineId;
                CategoryId.Value = meal.CategoryId;
            }
        }

        /// <summary>
        /// Обновить таблицу "Блюда"
        /// </summary>
        /// <param name="edited_meal">Измененное блюдо</param>
        private void UpdateDGV(Meal edited_meal)
        {
            for (int i = 0; i < ref_to_parent_form.MealsTable.RowCount; i++)
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

        /// <summary>
        /// Закрыть окно
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ExitMealEntityForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void Delete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                using (kursContext db = new kursContext())
                {
                    Meal meal = db.Meals.First(e => e.IdMeal == id);
                    db.Meals.Remove(meal);
                    db.SaveChanges();
                }


                // Удаление строки из таблицы
                for (int i = 0; i < ref_to_parent_form.MealsTable.RowCount; i++)
                {
                    if ((long)ref_to_parent_form.MealsTable.Rows[i].Cells[0].Value == id)
                    {
                        ref_to_parent_form.MealsTable.Rows.RemoveAt(i);
                        Close();
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Открыть окно "Виды кухонь"
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void OpenCuisinesForm_Click(object sender, EventArgs e)
        {
            CuisineForm cuisineForm = new CuisineForm(ref_to_parent_form);
            cuisineForm.ShowDialog();
        }

        /// <summary>
        /// Открыть окно "Категории блюд"
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void OpenCategoriesForm_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(ref_to_parent_form);
            categoryForm.ShowDialog();
        }
    }
}

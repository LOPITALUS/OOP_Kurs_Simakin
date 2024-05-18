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
    /// <summary>
    /// Окно добавления нового блюда
    /// </summary>
    public partial class AddMealForm : Form
    {
        /// <summary>
        /// Ссылка на родительское окно - "Меню"
        /// </summary>
        private MealForm ref_to_parent_form;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_ref_to_parent_form">Ссылка на родительское окно - "Меню"</param>
        public AddMealForm(MealForm _ref_to_parent_form)
        {
            InitializeComponent();
            ref_to_parent_form = _ref_to_parent_form;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление блюда в базу данных
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ApplyAddMealForm_Click(object sender, EventArgs e)
        {
            string name = NewMealName.Text;
            double weight = (double)NewMealWeight.Value;
            double kcal = (double)NewMealKcal.Value;
            double price = (double)NewMealPrice.Value;
            long cuisine_id = (long)CuisineId.Value;
            long category_id = (long)CategoryId.Value;

            if (name.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление");
                return;
            }

            using (kursContext db = new kursContext())
            {
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
                Meal new_meal = new Meal { Name = name, Weight = weight, Kcal = kcal, Price = price, Category = cat, Cuisine = cuis };
                db.Meals.Add(new_meal);
                db.SaveChanges();
                ref_to_parent_form.MealsTable.Rows.Add(new_meal.IdMeal, new_meal.Name, new_meal.Weight, new_meal.Kcal, new_meal.Price, new_meal.CuisineId, new_meal.CategoryId);
            }
            MessageBox.Show("Запись успешно добавлена", "Уведомление");
            ClearInput();
        }

        /// <summary>
        /// Очистка полей ввода
        /// </summary>
        private void ClearInput()
        {
            NewMealName.Text = "";
            NewMealWeight.Value = NewMealWeight.Minimum;
            NewMealKcal.Value = NewMealKcal.Minimum;
            NewMealPrice.Value = NewMealPrice.Minimum;
            CuisineId.Value = CuisineId.Minimum;
            CategoryId.Value = CategoryId.Minimum;
        }

        /// <summary>
        /// Открытие окна "Категории блюд"
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void OpenCategoriesForm_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(ref_to_parent_form);
            categoryForm.ShowDialog();
        }

        /// <summary>
        /// Открытие окна "Виды кухонь"
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void OpenCuisinesForm_Click(object sender, EventArgs e)
        {
            CuisineForm cuisineForm = new CuisineForm(ref_to_parent_form);
            cuisineForm.ShowDialog();
        }
    }
}

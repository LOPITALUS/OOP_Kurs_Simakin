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
    /// Окно добавления новой категории
    /// </summary>
    public partial class AddCategoryForm : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_ref_to_parent_form">Ссылка на родительскую форму - "Категории блюд"</param>
        public AddCategoryForm(CategoryForm _ref_to_parent_form)
        {
            InitializeComponent();
            ref_to_parent_form = _ref_to_parent_form;
        }

        /// <summary>
        /// Добавление в базу данных новой категории
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ApplyAddCategoryForm_Click(object sender, EventArgs e)
        {
            string new_category_name = NewCategoryName.Text;
            string new_category_descr = NewCategoryDescription.Text;

            if (new_category_name.Length == 0 || new_category_descr.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление");
                return;
            }


            Category new_category = new Category(new_category_name, new_category_descr);
            kursContext db = new kursContext();

            db.Categories.Add(new_category);
            db.SaveChanges();
            MessageBox.Show("Запись успешно добавлена", "Уведомление");
            ref_to_parent_form.CategoriesTable.Rows.Add(new_category.CategoryId, new_category.Name, new_category.Description);
            ClearInput();
        }

        /// <summary>
        /// Очистка ввода в окне
        /// </summary>
        private void ClearInput()
        {
            NewCategoryName.Text = "";
            NewCategoryDescription.Text = "";
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ExitAddCategoryForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ссылка на родительское окно - "Категории блюд"
        /// </summary>
        private CategoryForm ref_to_parent_form;
    }
}

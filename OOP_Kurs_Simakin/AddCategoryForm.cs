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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        public AddCategoryForm(MealForm meal_form)
        {
            InitializeComponent();
            ref_to_parent_form = meal_form;
        }

        private void ApplyAddCategoryForm_Click(object sender, EventArgs e)
        {
            string new_category_name = NewCategoryName.Text;
            string new_category_descr = NewCategoryDescription.Text;
            Category new_category = new Category(new_category_name, new_category_descr);

            kursContext db = new kursContext();

            // Проверка, что с заданными данными нет записи

            db.Categories.Add(new_category);
            db.SaveChanges();

            // Обновить список в таблице со всеми категориями

            // Обновить выпадающий список 

        }

        private void ExitAddCategoryForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Form ref_to_parent_form;
    }
}

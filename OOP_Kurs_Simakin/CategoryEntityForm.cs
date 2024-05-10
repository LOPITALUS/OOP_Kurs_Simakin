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
    public partial class CategoryEntityForm : Form
    {
        private long id;
        private CategoryForm ref_to_parent_form;
        public CategoryEntityForm(long _id, CategoryForm _ref_to_parent_form)
        {
            InitializeComponent();
            id = _id;
            ref_to_parent_form = _ref_to_parent_form;
        }

        private void ApplyChanges_Click(object sender, EventArgs e)
        {
            string edited_category_name = EditedCategoryName.Text;
            string edited_category_descr = EditedCategoryDescription.Text;

            if (edited_category_name.Length == 0 || edited_category_descr.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление");
                return;
            }

            using (kursContext db = new kursContext())
            {
                Category cat = db.Categories.First(e => e.CategoryId == id);
                cat.Name = edited_category_name;
                cat.Description = edited_category_descr;
                db.SaveChanges();
                UpdateDGV(cat);
            }
        }

        private void UpdateDGV(Category edited_category)
        {
            for (int i = 0; i < ref_to_parent_form.CategoriesTable.RowCount; i++)
            {
                if ((long)ref_to_parent_form.CategoriesTable.Rows[i].Cells[0].Value == id)
                {
                    ref_to_parent_form.CategoriesTable.Rows[i].Cells[1].Value = edited_category.Name;
                    ref_to_parent_form.CategoriesTable.Rows[i].Cells[2].Value = edited_category.Description;
                    return;
                }
            }
        }

        private void ExitCategoryEntityForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                Category category = db.Categories.First(e => e.CategoryId == id);
                db.Categories.Remove(category);
                db.SaveChanges();
            }


            // Удаление строки из таблицы
            for (int i = 0; i < ref_to_parent_form.CategoriesTable.RowCount; i++)
            {
                if ((long)ref_to_parent_form.CategoriesTable.Rows[i].Cells[0].Value == id)
                {
                    ref_to_parent_form.CategoriesTable.Rows.RemoveAt(i);
                    Close();
                    return;
                }
            }
        }

        private void CategoryEntityForm_Load(object sender, EventArgs e)
        {
            Text = $"ID : {id}";
            using (kursContext db = new kursContext())
            {
                Category cat = db.Categories.First(e => e.CategoryId == id);
                EditedCategoryName.Text = cat.Name;
                EditedCategoryDescription.Text = cat.Description;
            }
        }
    }
}

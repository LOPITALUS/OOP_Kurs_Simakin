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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCuisineForm = new AddCategoryForm(this);
            addCuisineForm.ShowDialog();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ResetCategoryDGV();
        }

        private void ResetCategoryDGV()
        {
            CategoriesTable.Rows.Clear();
            using (kursContext db = new kursContext())
            {
                var categories = db.Categories.ToList();
                foreach (var category in categories)
                {
                    CategoriesTable.Rows.Add(category.CategoryId, category.Name, category.Description);
                }
            }
        }

        private void CategoriesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long current_id = (long)CategoriesTable.Rows[e.RowIndex].Cells[0].Value;
                CategoryEntityForm cef = new CategoryEntityForm(current_id, this);
                cef.ShowDialog();
            }
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            CategoriesTable.Rows.Clear();
            string current_name = NameForSearching.Text;
            using (kursContext db = new kursContext())
            {
                var categories = db.Categories.ToList();
                foreach (var category in categories)
                {
                    if (category.Name == current_name)
                        CategoriesTable.Rows.Add(category.CategoryId, category.Name, category.Description);
                }
            }
        }

        private void SearchIdButton_Click(object sender, EventArgs e)
        {
            long current_id = (long)IdForSearching.Value;
            using (kursContext db = new kursContext())
            {
                if (db.Categories.FirstOrDefault(c => c.CategoryId == current_id) != null)
                {
                    CategoryEntityForm cef = new CategoryEntityForm(current_id, this);
                    cef.ShowDialog();
                }
                else
                    MessageBox.Show("По данному ID нет записей", "Уведомление");
            }
        }

        private void CancelFilters_Click(object sender, EventArgs e)
        {
            ResetCategoryDGV();
            MessageBox.Show("Все фильтры сняты\nТаблица показывает актуальную таблицу из БД", "Уведомление");
        }
    }
}

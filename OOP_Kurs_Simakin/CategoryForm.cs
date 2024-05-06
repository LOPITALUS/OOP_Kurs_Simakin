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
            AddCategoryForm addCuisineForm = new AddCategoryForm();
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
    }
}

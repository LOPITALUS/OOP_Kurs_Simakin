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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Открытие окна добаления
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMealForm addMealForm = new AddMealForm();
            addMealForm.ShowDialog();
        }

        private void AddNewCuisine_Click(object sender, EventArgs e)
        {

        }

        private void AddNewCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
        }
    }
}

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
    public partial class AddCuisineForm : Form
    {
        public AddCuisineForm()
        {
            InitializeComponent();
        }

        private void ApplyAddCuisinelForm_Click(object sender, EventArgs e)
        {
            string new_cuisine_name = NewCuisineName.Text;
            string new_cuisine_descr = NewCuisineDescription.Text;
            Cuisine new_cuisine = new Cuisine(new_cuisine_name, new_cuisine_descr);

            kursContext db = new kursContext();

            // Проверка, что с заданными данными нет записи

            db.Cuisines.Add(new_cuisine);
            db.SaveChanges();
        }

        private void ExitAddCuisineForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurs_Simakin
{
    public partial class CuisineEntityForm : Form
    {
        private long id;
        private CuisineForm ref_to_parent_form;
        public CuisineEntityForm(long _id, CuisineForm _ref_to_parent_form)
        {
            InitializeComponent();
            id = _id;
            ref_to_parent_form = _ref_to_parent_form;
        }

        private void UpdateDGV(Cuisine edited_cuisine)
        {
            for (int i = 0; i < ref_to_parent_form.CuisinesTable.RowCount; i++)
            {
                if ((long)ref_to_parent_form.CuisinesTable.Rows[i].Cells[0].Value == id)
                {
                    ref_to_parent_form.CuisinesTable.Rows[i].Cells[1].Value = edited_cuisine.Name;
                    ref_to_parent_form.CuisinesTable.Rows[i].Cells[2].Value = edited_cuisine.Description;
                    return;
                }
            }
        }

        private void ExitCuisineEntityForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyChanges_Click(object sender, EventArgs e)
        {
            string edited_name = EditedCuisineName.Text;
            string edited_descr = EditedCuisineDescription.Text;

            if (edited_name.Length == 0 || edited_descr.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление");
                return;
            }

            using (kursContext db = new kursContext())
            {
                Cuisine cuis = db.Cuisines.First(e => e.CuisineId == id);
                cuis.Name = edited_name;
                cuis.Description = edited_descr;
                db.SaveChanges();
                UpdateDGV(cuis);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (kursContext db = new kursContext())
            {
                Cuisine cuisine = db.Cuisines.First(e => e.CuisineId == id);
                db.Cuisines.Remove(cuisine);
                db.SaveChanges();
            }


            // Удаление строки из таблицы
            for (int i = 0; i < ref_to_parent_form.CuisinesTable.RowCount; i++)
            {
                if ((long)ref_to_parent_form.CuisinesTable.Rows[i].Cells[0].Value == id)
                {
                    ref_to_parent_form.CuisinesTable.Rows.RemoveAt(i);
                    Close();
                    return;
                }
            }
        }

        private void CuisineEntityForm_Load(object sender, EventArgs e)
        {
            Text = $"ID : {id}";
            using (kursContext db = new kursContext())
            {
                Cuisine cuis = db.Cuisines.First(e => e.CuisineId == id);
                EditedCuisineName.Text = cuis.Name;
                EditedCuisineDescription.Text = cuis.Description;
            }
        }
    }
}

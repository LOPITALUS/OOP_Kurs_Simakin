﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_Kurs_Simakin
{
    public partial class AddCuisineForm : Form
    {
        public AddCuisineForm(CuisineForm _ref_to_parent_form)
        {
            InitializeComponent();
            ref_to_parent_form = _ref_to_parent_form;
        }

        private void ApplyAddCuisinelForm_Click(object sender, EventArgs e)
        {
            string new_cuisine_name = NewCuisineName.Text;
            string new_cuisine_descr = NewCuisineDescription.Text;

            if (new_cuisine_name.Length == 0 || new_cuisine_descr.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление");
                return;
            }

            Cuisine new_cuisine = new Cuisine(new_cuisine_name, new_cuisine_descr);

            kursContext db = new kursContext();

            db.Cuisines.Add(new_cuisine);
            db.SaveChanges();
            MessageBox.Show("Запись успешно добавлена", "Уведомление");
            ref_to_parent_form.CuisinesTable.Rows.Add(new_cuisine.CuisineId, new_cuisine.Name, new_cuisine.Description);
            ClearInput();
        }

        private void ClearInput()
        {
            NewCuisineName.Text = "";
            NewCuisineDescription.Text = "";
        }

        private void ExitAddCuisineForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    
        private CuisineForm ref_to_parent_form;
    }
}

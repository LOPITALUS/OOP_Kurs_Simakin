﻿using System;
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
    public partial class CuisineForm : Form
    {
        public CuisineForm()
        {
            InitializeComponent();
        }

        private void AddCuisineBtn_Click(object sender, EventArgs e)
        {
            AddCuisineForm addCuisineForm = new AddCuisineForm(this);
            addCuisineForm.ShowDialog();
        }

        private void CuisineForm_Load(object sender, EventArgs e)
        {
            ResetCuisineDGV();
        }
        private void ResetCuisineDGV()
        {
            CuisinesTable.Rows.Clear();
            using (kursContext db = new kursContext())
            {
                var cuisines = db.Cuisines.ToList();
                foreach (var cuisine in cuisines)
                {
                    CuisinesTable.Rows.Add(cuisine.CuisineId, cuisine.Name, cuisine.Description);
                }
            }
        }

        private void CuisinesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long current_id = (long)CuisinesTable.Rows[e.RowIndex].Cells[0].Value;
            CuisineEntityForm cef = new CuisineEntityForm(current_id, this);
            cef.ShowDialog();
        }
    }
}

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

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            CuisinesTable.Rows.Clear();
            string current_name = NameForSearching.Text;
            using (kursContext db = new kursContext())
            {
                var cuisines = db.Cuisines.ToList();
                foreach (var cuisine in cuisines)
                {
                    if (cuisine.Name == current_name)
                        CuisinesTable.Rows.Add(cuisine.CuisineId, cuisine.Name, cuisine.Description);
                }
            }
        }

        private void SearchIdButton_Click(object sender, EventArgs e)
        {
            long current_id = (long)IdForSearching.Value;
            using (kursContext db = new kursContext())
            {
                if (db.Cuisines.FirstOrDefault(c => c.CuisineId == current_id) != null)
                {
                    CuisineEntityForm cef = new CuisineEntityForm(current_id, this);
                    cef.ShowDialog();
                }
                else
                    MessageBox.Show("По данному ID нет записей", "Уведомление");
            }
        }

        private void CancelFilters_Click(object sender, EventArgs e)
        {
            ResetCuisineDGV();
            MessageBox.Show("Все фильтры сняты\nТаблица показывает актуальную таблицу из БД", "Уведомление");
        }
    }
}

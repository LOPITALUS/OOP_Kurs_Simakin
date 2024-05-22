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
    /// <summary>
    /// Окно "Виды кухонь"
    /// </summary>
    public partial class CuisineForm : Form
    {
        /// <summary>
        /// Ссылка на окно "Меню"
        /// </summary>
        private MealForm ref_to_main_form;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_ref_to_main_form">Ссылка на окно "Меню"</param>
        public CuisineForm(MealForm _ref_to_main_form)
        {
            InitializeComponent();
            ref_to_main_form = _ref_to_main_form;
        }

        /// <summary>
        /// Открыть окно добавления
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void AddCuisineBtn_Click(object sender, EventArgs e)
        {
            AddCuisineForm addCuisineForm = new AddCuisineForm(this);
            addCuisineForm.ShowDialog();
        }

        /// <summary>
        /// Построить таблицу при загрузке
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CuisineForm_Load(object sender, EventArgs e)
        {
            ResetCuisineDGV();
        }

        /// <summary>
        /// Построить таблицу
        /// </summary>
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

        /// <summary>
        /// Открыть представление записи при клике
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CuisinesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long current_id = (long)CuisinesTable.Rows[e.RowIndex].Cells[0].Value;
                CuisineEntityForm cef = new CuisineEntityForm(current_id, ref_to_main_form, this);
                cef.ShowDialog();
            }
        }

        /// <summary>
        /// Поиск по названию
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            CuisinesTable.Rows.Clear();
            string current_name = NameForSearching.Text;
            long final_count = 0;
            using (kursContext db = new kursContext())
            {
                var cuisines = db.Cuisines.ToList();
                foreach (var cuisine in cuisines)
                {
                    if (cuisine.Name == current_name)
                    {
                        CuisinesTable.Rows.Add(cuisine.CuisineId, cuisine.Name, cuisine.Description);
                        final_count++;
                    }
                }
            }
            MessageBox.Show($"Найдено записей: {final_count}\nВсего записей: {GetDbCount()}", "Уведомление");
            CancelFilters.Enabled = true;
        }

        /// <summary>
        /// Поиск по идентификатору
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void SearchIdButton_Click(object sender, EventArgs e)
        {
            long current_id = (long)IdForSearching.Value;
            using (kursContext db = new kursContext())
            {
                if (db.Cuisines.FirstOrDefault(c => c.CuisineId == current_id) != null)
                {
                    CuisineEntityForm cef = new CuisineEntityForm(current_id, ref_to_main_form, this);
                    cef.ShowDialog();
                }
                else
                    MessageBox.Show("По данному ID нет записей", "Уведомление");
            }
        }

        /// <summary>
        /// Снять все фильтры
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CancelFilters_Click(object sender, EventArgs e)
        {
            ResetCuisineDGV();
            MessageBox.Show("Все фильтры сняты\nТаблица показывает актуальную таблицу из БД", "Уведомление");
            CancelFilters.Enabled = false;
        }

        /// <summary>
        /// Подсчет записей в таблице "Кухни"
        /// </summary>
        /// <returns>Кол-во записей</returns>
        private long GetDbCount()
        {
            using (kursContext db = new kursContext())
            {
                return db.Cuisines.LongCount();
            }
        }
    }
}

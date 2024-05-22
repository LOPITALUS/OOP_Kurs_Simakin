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
    /// Окно "Категории блюд"
    /// </summary>
    public partial class CategoryForm : Form
    {
        /// <summary>
        /// Ссылка на окно "Меню"
        /// </summary>
        private MealForm ref_to_main_form;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_ref_to_main_form">Ссылка на окно "Меню"</param>
        public CategoryForm(MealForm _ref_to_main_form)
        {
            InitializeComponent();
            ref_to_main_form = _ref_to_main_form;
        }

        /// <summary>
        /// Перейти в окно создания
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCuisineForm = new AddCategoryForm(this);
            addCuisineForm.ShowDialog();
        }

        /// <summary>
        /// Построение таблицы при загрузке
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ResetCategoryDGV();
        }

        /// <summary>
        /// Построение таблицы
        /// </summary>
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

        /// <summary>
        /// Открытие представление записи при клике на строку таблицы
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CategoriesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long current_id = (long)CategoriesTable.Rows[e.RowIndex].Cells[0].Value;
                CategoryEntityForm cef = new CategoryEntityForm(current_id, ref_to_main_form, this);
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
            CategoriesTable.Rows.Clear();
            string current_name = NameForSearching.Text;
            long final_count = 0;
            using (kursContext db = new kursContext())
            {
                var categories = db.Categories.ToList();
                foreach (var category in categories)
                {
                    if (category.Name == current_name)
                    {
                        CategoriesTable.Rows.Add(category.CategoryId, category.Name, category.Description);
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
                if (db.Categories.FirstOrDefault(c => c.CategoryId == current_id) != null)
                {
                    CategoryEntityForm cef = new CategoryEntityForm(current_id, ref_to_main_form, this);
                    cef.ShowDialog();
                }
                else
                    MessageBox.Show("По данному ID нет записей", "Уведомление");
            }
        }

        /// <summary>
        /// Снятие всех фильтров с таблицы
        /// </summary>
        /// <param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void CancelFilters_Click(object sender, EventArgs e)
        {
            ResetCategoryDGV();
            MessageBox.Show("Все фильтры сняты\nТаблица показывает актуальную таблицу из БД", "Уведомление");
            CancelFilters.Enabled = false;
        }

        /// <summary>
        /// Подсчет записей в таблице "Категории"
        /// </summary>
        /// <returns>Кол-во записей</returns>
        private long GetDbCount()
        {
            using (kursContext db = new kursContext())
            {
                return db.Categories.LongCount();
            }
        }
    }
}

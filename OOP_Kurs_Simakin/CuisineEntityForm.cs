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
    /// <summary>
    /// Окно предстваления вида кухни
    /// </summary>
    public partial class CuisineEntityForm : Form
    {
        /// <summary>
        /// Идентификатор открытой записи
        /// </summary>
        private long id;

        /// <summary>
        /// Ссылка на окно "Меню"
        /// </summary>
        private MealForm ref_to_main_form;

        /// <summary>
        /// Ссылка на родительское окно - "Виды кухонь"
        /// </summary>
        private CuisineForm ref_to_parent_form;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_id">Идентификатор открытой записи</param>
        /// <param name="_ref_to_main_form">Ссылка на окно "Меню"</param>
        /// <param name="_ref_to_parent_form">Ссылка на родительское окно - "Виды кухонь"</param>
        public CuisineEntityForm(long _id, MealForm _ref_to_main_form, CuisineForm _ref_to_parent_form)
        {
            InitializeComponent();
            id = _id;
            ref_to_main_form = _ref_to_main_form;
            ref_to_parent_form = _ref_to_parent_form;
        }

        /// <summary>
        /// Обновление таблицы видов кухонь
        /// </summary>
        /// <param name="edited_cuisine">Измененная кухня</param>
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

        /// <summary>
        /// Закрыть окно
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ExitCuisineEntityForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
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

        /// <summary>
        /// Удалить запись
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void Delete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("При удалении данной кухни, все связанные блюда также удалятся. " +
                "Все равно удалить?", "Внимание", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
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
                        break;
                    }
                }

                ref_to_main_form.ResetMealsDGV();
            }
        }

        /// <summary>
        /// Заполнение информации о записи при загрузке окна
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
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

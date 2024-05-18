using System;
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
    /// <summary>
    /// Окно добавления нового вида кухни
    /// </summary>
    public partial class AddCuisineForm : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_ref_to_parent_form">Ссылка на родительскую форму - "Виды кухонь"</param>
        public AddCuisineForm(CuisineForm _ref_to_parent_form)
        {
            InitializeComponent();
            ref_to_parent_form = _ref_to_parent_form;
        }

        /// <summary>
        /// Добавление в базу данных новой кухни
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
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

        /// <summary>
        /// Очистка ввода в окне
        /// </summary>
        private void ClearInput()
        {
            NewCuisineName.Text = "";
            NewCuisineDescription.Text = "";
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ExitAddCuisineForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ссылка на родительское окно - "Виды кухонь"
        /// </summary>
        private CuisineForm ref_to_parent_form;
    }
}

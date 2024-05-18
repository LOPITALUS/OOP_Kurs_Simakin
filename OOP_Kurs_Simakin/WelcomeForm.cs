namespace OOP_Kurs_Simakin
{
    /// <summary>
    /// Форма с информацией об авторе при запуске программы
    /// </summary>
    public partial class WelcomeForm : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public WelcomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку для перехода к программе
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
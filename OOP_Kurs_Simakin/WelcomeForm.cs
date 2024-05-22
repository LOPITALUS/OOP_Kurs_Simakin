using System.Diagnostics;

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

            var tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate { this.Close(); };
            tmr.Interval = (int)TimeSpan.FromSeconds(10).TotalMilliseconds;
            tmr.Start();
        }

        /// <summary>
        /// Нажатие на кнопку для перехода к программе
        /// </summary>
        ///<param name = "sender" > Источник события</param>
        /// <param name="e">Объект с дополнительной информацией</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
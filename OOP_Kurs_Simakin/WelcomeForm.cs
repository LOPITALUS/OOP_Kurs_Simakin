namespace OOP_Kurs_Simakin
{
    /// <summary>
    /// ����� � ����������� �� ������ ��� ������� ���������
    /// </summary>
    public partial class WelcomeForm : Form
    {
        /// <summary>
        /// �����������
        /// </summary>
        public WelcomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ������� �� ������ ��� �������� � ���������
        /// </summary>
        ///<param name = "sender" > �������� �������</param>
        /// <param name="e">������ � �������������� �����������</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
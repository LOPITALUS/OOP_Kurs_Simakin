namespace OOP_Kurs_Simakin
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            /* kursContext db = new kursContext();
             Category new_category = new Category("Test1");
             db.Add(new_category);
             db.SaveChanges();
            */

            //Meal test1 = new Meal("��������", 200, 200, 200, 1, 1);


            // db.Add();
            // db.SaveChanges();
        }
    }
}
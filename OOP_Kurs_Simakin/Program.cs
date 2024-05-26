namespace OOP_Kurs_Simakin
{
    /// <summary>
    /// Класс с точкой входа
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  Точка входа
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MealForm());
        }
    }
}
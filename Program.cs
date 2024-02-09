namespace _11._09._2001
{
    internal static class Program
    {
        public static Form1 form1 = new Form1();
        public static Aunt aunt = new Aunt(form1);

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            aunt.Show();

            Application.Run(form1);
        }
    }
}
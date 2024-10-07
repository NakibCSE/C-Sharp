namespace EmployeeInformation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Person_sName());

            Employee employee1 = new Employee();
            employee1.id = "Emp-22";
            employee1.name = "Nakib Khan";
            employee1.salaryAmount = 30000;

            Employee employee2 = new Employee();
            employee2.id = "Emp-23";
            employee2.name = "Nahid Khan";
            employee2.salaryAmount = 40000;
        }
    }
}
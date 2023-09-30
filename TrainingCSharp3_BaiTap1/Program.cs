namespace TrainingCSharp3_BaiTap1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        // Scaffold-DbContext "Server=DESKTOP-B52SRBN\SQLEXPRESS;Database= FINALASS_FPOLY_NET_JAVA_SM22_BL2;Trusted_Connection=True;"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        // Scaffold-DbContext 'Data Source=DESKTOP-B52SRBN\SQLEXPRESS;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Integrated Security=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations  -Force
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new View.FrmXeMay());
        }
    }
}
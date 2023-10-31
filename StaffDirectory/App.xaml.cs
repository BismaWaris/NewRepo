using StaffDirectory.Pages;
using StaffDirectory.Data;
using System.IO;

namespace StaffDirectory
{
    public partial class App : Application
    {
        public static DatabaseHelper Database;

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Staff.db3");
            Database = new DatabaseHelper(dbPath);

                MainPage = new NavigationPage(new EmployeeListPage());
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            //const int newWidth = 450;
            //const int newHeight = 750;

            //window.Width = newWidth;
            //window.Height = newHeight;




            return window;
        }

    }
}
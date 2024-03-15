using P6Assets2024_OscarZ.Views;

namespace P6Assets2024_OscarZ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}

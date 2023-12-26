namespace Revision
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.ProfilePage();
        }
    }
}
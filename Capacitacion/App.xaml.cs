using Xamarin.Forms;

namespace Capacitacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterPageDetail();
            //MainPage = new NavigationPage(new ComidasFavoritasPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

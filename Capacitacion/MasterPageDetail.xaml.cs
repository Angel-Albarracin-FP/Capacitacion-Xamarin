using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capacitacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageDetail : MasterDetailPage
    {
        public MasterPageDetail()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Models.MenuItem) e.SelectedItem;
            if (item == null)
                return;

            switch (item.Titulo)
            {
                case "Calculadora":
                    Detail = new NavigationPage(new CalculadoraPage());
                    break;
                case "Comidas Favoritas":
                    Detail = new NavigationPage(new ComidasFavoritasPage());
                    break;
                default:
                    break;
            }

            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}
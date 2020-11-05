using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capacitacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateralPageMaster : ContentPage
    {
        public ListView ListView;

        public MenuLateralPageMaster()
        {
            InitializeComponent();
            ListView = MenuItemsListView;
        }

    }
}
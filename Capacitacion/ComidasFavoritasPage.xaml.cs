using Capacitacion.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Capacitacion
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ComidasFavoritasPage : ContentPage
    {
        public ComidasFavoritasPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<VMComidasFavoritas>(this, "AddComida", async (a) =>
            {
                await Navigation.PushModalAsync(new ComidaFavoritaNewPage());
            });
        }
    }
}

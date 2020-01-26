using Capacitacion.Models;
using Capacitacion.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

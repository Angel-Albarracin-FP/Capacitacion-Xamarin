using Capacitacion.Models;
using Capacitacion.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capacitacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComidaFavoritaNewPage : ContentPage
    {
        public ComidaFavoritaNewPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<VMComidaFavoritaNew, ComidaFavorita>(this, "SaveComida", async (a, s) => {
                await Navigation.PopModalAsync();
            });
        }
    }
}
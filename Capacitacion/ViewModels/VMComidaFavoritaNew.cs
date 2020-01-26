using Capacitacion.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace Capacitacion.ViewModels
{
    class VMComidaFavoritaNew : VMBase
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; OnPropertyChanged(nameof(Nombre)); }
		}

		private string comida;

		public string Comida
		{
			get { return comida; }
			set { comida = value; OnPropertyChanged(nameof(Comida)); }
		}

		public ICommand Save { get; set; }

		public VMComidaFavoritaNew()
		{
			Save = new Command(() =>
			{
				var comidaFavorita = new ComidaFavorita() { Comida = Comida, Nombre = Nombre };
				MessagingCenter.Send(this, "SaveComida", comidaFavorita);
			});
		}

	}
}

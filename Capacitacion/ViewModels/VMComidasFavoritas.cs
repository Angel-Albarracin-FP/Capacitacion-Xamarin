using Capacitacion.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Capacitacion.ViewModels
{
    class VMComidasFavoritas : NotificationObject
    {
		private ObservableCollection<ComidaFavorita> comidasFavoritas;

		public ObservableCollection<ComidaFavorita> ComidasFavoritas
		{
			get { return comidasFavoritas; }
			set { comidasFavoritas = value; OnPropertyChanged(); }
		}

		public ICommand AddComida { get; set; }

		public VMComidasFavoritas()
		{
			ComidasFavoritas = new ObservableCollection<ComidaFavorita>();

			AddComida = new Command(() =>
			{
				MessagingCenter.Send(this, "AddComida");
			});

			MessagingCenter.Subscribe<VMComidaFavoritaNew, ComidaFavorita>(this, "SaveComida", (a, s) => {
				ComidasFavoritas.Add(s);
			});

		}

	}
}

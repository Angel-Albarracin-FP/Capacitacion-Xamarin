using Capacitacion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Capacitacion.ViewModels
{
    class VMComidasFavoritas
    {
		public ObservableCollection<ComidaFavorita> ComidasFavoritas { get; set; }

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

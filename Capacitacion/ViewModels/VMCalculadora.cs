using System.Windows.Input;
using Xamarin.Forms;

namespace Capacitacion.ViewModels
{
    public class VMCalculadora : NotificationObject
    {
        public VMCalculadora()
        {
            Sumar = new Command(() => { Resultado = NumeroUno + NumeroDos; });
            Restar = new Command(() => { Resultado = NumeroUno - NumeroDos; });
            Multiplicar = new Command(() => { Resultado = NumeroUno * NumeroDos; });
            Dividir = new Command(() => { Resultado = NumeroUno / NumeroDos; });
        }

		private decimal numeroUno;

		public decimal NumeroUno
		{
			get { return numeroUno; }
			set { numeroUno = value; OnPropertyChanged(); }
		}

		private decimal numeroDos;

		public decimal NumeroDos
		{
			get { return numeroDos; }
			set { numeroDos = value; OnPropertyChanged(); }
		}

		private decimal resultado;

		public decimal Resultado
		{
			get { return resultado; }
			set { resultado = value; OnPropertyChanged(); }
		}

		public ICommand Sumar { get; set; }
        public ICommand Restar { get; set; }
        public ICommand Multiplicar { get; set; }
        public ICommand Dividir { get; set; }

	}
}

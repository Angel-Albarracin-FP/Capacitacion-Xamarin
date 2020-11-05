using Capacitacion.Models;
using System.Collections.ObjectModel;

namespace Capacitacion.ViewModels
{
    class VMMenuLateral
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public VMMenuLateral()
        {
            MenuItems = new ObservableCollection<MenuItem>(new[]
            {
                new MenuItem { Titulo = "Calculadora" },
                new MenuItem { Titulo = "Comidas Favoritas" },
                new MenuItem { Titulo = "Contenedores" }
            });
        }

    }
}

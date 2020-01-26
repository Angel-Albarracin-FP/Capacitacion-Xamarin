using System.Collections.ObjectModel;

namespace Capacitacion.ViewModels
{
    class VMMenuLateral
    {
        public ObservableCollection<Models.MenuItem> MenuItems { get; set; }

        public VMMenuLateral()
        {
            MenuItems = new ObservableCollection<Models.MenuItem>(new[]
            {
                new Models.MenuItem { Titulo = "Calculadora" },
                new Models.MenuItem { Titulo = "Comidas Favoritas" }
            });
        }

    }
}

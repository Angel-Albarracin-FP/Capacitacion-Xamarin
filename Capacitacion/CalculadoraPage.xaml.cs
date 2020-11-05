﻿using Capacitacion.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capacitacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraPage : ContentPage
    {
        public CalculadoraPage()
        {
            BindingContext = new VMCalculadora();
            InitializeComponent();
        }
    }
}
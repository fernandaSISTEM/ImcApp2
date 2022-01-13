using ImcApp.Models;
using System;
using Xamarin.Forms;
using ImcApp.ViewModels;

//FERNANDA GPE..
//SEGUNDA OPORTUNIDAD2

namespace ImcApp.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }

        private string GetEstadoNutricional(CalculadoraImc.EstadoNutricional estado)
        {
            switch (estado)
            {
                case CalculadoraImc.EstadoNutricional.PesoBajo:
                    return Resources["TextoPesoBajo"] as string;
                case CalculadoraImc.EstadoNutricional.PesoNormal:
                    return Resources["TextoPesoNormal"] as string;
                case CalculadoraImc.EstadoNutricional.SobrePeso:
                    return Resources["TextoSobrepeso"] as string;
                case CalculadoraImc.EstadoNutricional.Obesidad:
                    return Resources["TextoObesidad"] as string;
                case CalculadoraImc.EstadoNutricional.ObesidadExtrema:
                    return Resources["TextoObesidadExtrema"] as string;
                default:
                    return string.Empty;
            }
        }
    }
}
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace WpfMvvmNet6.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textoPrueba = "Esto es un texto de prueba";

        [RelayCommand]
        private void CambiarTexto()
        {
            TextoPrueba = $"Modificado a las {DateTime.Now.ToLongTimeString()}";
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmNet6.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textoPrueba = "Esto es un texto de prueba";
    }
}

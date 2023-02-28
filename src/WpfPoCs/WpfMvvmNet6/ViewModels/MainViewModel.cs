using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;
using WpfMvvmNet6.Services;

namespace WpfMvvmNet6.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        #region Propiedades Observables
        [ObservableProperty]
        private string textoPrueba = "Esto es un texto de prueba";
        #endregion

        #region Ciclo de vida
        private IWindowService _windowService;
        private SegunderoService _segunderoService;

        public MainViewModel()
        {
            _windowService = new WindowService();
            _segunderoService = new SegunderoService();
        }

        public MainViewModel(IWindowService windowService, SegunderoService segunderoService)
        {
            _windowService = windowService;
            _segunderoService = segunderoService;
        }
        #endregion

        #region Comandos
        [RelayCommand]
        private void CambiarTexto()
        {
            TextoPrueba = $"Modificado a las {DateTime.Now.ToLongTimeString()}";
        }

        [RelayCommand]
        private void OpenWindow(Ventanas ventana)
        {
            _windowService.Show(ventana);
        }

        [RelayCommand]
        private async Task StartSegundero()
        {
            await _segunderoService.StartAsync(new System.Threading.CancellationToken());
        }
        #endregion
    }
}

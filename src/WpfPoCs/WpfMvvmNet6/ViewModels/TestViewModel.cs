using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Threading.Tasks;
using WpfMvvmNet6.Messaging.Messages;
using WpfMvvmNet6.Services;

namespace WpfMvvmNet6.ViewModels
{
    public partial class TestViewModel : ObservableObject
    {
        #region Propiedades Observables
        [ObservableProperty]
        private string etiqueta = "Segundero actual: ";

        [ObservableProperty]
        private int segundos = -1;
        #endregion

        #region Ciclo de Vida
        private IWindowService _windowService;

        public TestViewModel()
        {
            _windowService = new WindowService();
        }
        public TestViewModel(IWindowService windowService)
        {
            _windowService = windowService;
        }
        #endregion

        #region Comandos
        [RelayCommand]
        public async Task RecuperarSegundosAsync()
        {
            Segundos = await WeakReferenceMessenger.Default.Send<CurrentSegunderoRequestMessage>();
        }

        [RelayCommand]
        public void Close()
        {
            _windowService.Close();
        } 
        #endregion
    }
}

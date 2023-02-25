using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfMvvmNet6.Services;

namespace WpfMvvmNet6.ViewModels
{
    public partial class TestViewModel : ObservableObject
    {
        #region Propiedades Observables
        [ObservableProperty]
        private string nombre = "Fulanito"; 
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
        public void Close()
        {
            _windowService.Close();
        } 
        #endregion
    }
}

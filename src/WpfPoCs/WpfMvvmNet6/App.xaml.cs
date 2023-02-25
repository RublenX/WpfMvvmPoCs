using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;
using System.Windows;
using WpfMvvmNet6.Services;
using WpfMvvmNet6.ViewModels;

namespace WpfMvvmNet6
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Ciclo de Vida
        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
        } 
        #endregion

        #region Métodos Auxiliares
        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Servicios
            services.AddSingleton<IWindowService, WindowService>();

            // VistaModelos
            services.AddTransient<MainViewModel>();
            services.AddTransient<TestViewModel>();

            return services.BuildServiceProvider();
        } 
        #endregion
    }
}

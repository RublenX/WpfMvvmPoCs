using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfMvvmNet6.ViewModels;

namespace WpfMvvmNet6.Views
{
    /// <summary>
    /// Lógica de interacción para TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
            this.DataContext = App.Current.Services.GetService<TestViewModel>();
        }
    }
}

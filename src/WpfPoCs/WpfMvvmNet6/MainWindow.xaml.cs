using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfMvvmNet6.ViewModels;

namespace WpfMvvmNet6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Ventanas Ventana { get; set; } = Ventanas.Segundero;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = App.Current.Services.GetService<MainViewModel>();
        }
    }
}

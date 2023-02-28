using System.Linq;
using System.Windows;
using WpfMvvmNet6.Views;

namespace WpfMvvmNet6.Services
{
    public class WindowService : IWindowService
    {
        public void Close()
        {
            var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive);

            if (window != null)
            {
                window.Close();
            }
        }

        public void Show(Ventanas ventana)
        {
            Window? window = null;

            switch (ventana)
            {
                case Ventanas.Main:
                    window = new MainWindow();
                    break;
                case Ventanas.Test:
                    window = new TestWindow();
                    break;
                case Ventanas.Segundero:
                    window = new SegunderoWindow();
                    break;
            }

            window?.Show();
        }
    }
}

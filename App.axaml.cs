
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using RegistroVideojuegos.Views;

namespace RegistroVideojuegos
{
    public partial class App : Application
    {
        // Cargar la configuración visual de la aplicación
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        // Abrir la ventana principal
        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}


using Avalonia;
using System;

namespace RegistroVideojuegos
{
    internal class Program
    {
        // Punto de inicio de la aplicación
        [STAThread]
        public static void Main(string[] args)
        {
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }

        // Configurar y preparar la aplicación gráfica
        public static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace();
        }
    }
}

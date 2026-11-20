
using Avalonia.Controls;
using Avalonia.Interactivity;
using RegistroVideojuegos.Models;
using RegistroVideojuegos.Services;
using System;

namespace RegistroVideojuegos.Views
{
    public partial class MainWindow : Window
    {
        // Servicio encargado de gestionar los videojuegos
        private readonly VideojuegoServicio servicio;

        // Constructor principal de la ventana
        public MainWindow()
        {
            InitializeComponent();

            // Inicializar el servicio de videojuegos
            servicio = new VideojuegoServicio();

            // Cargar los videojuegos al abrir la ventana
            CargarVideojuegos();
        }

        // Consultar los videojuegos registrados y mostrarlos en la interfaz
        private void CargarVideojuegos()
        {
            // Obtener todos los videojuegos almacenados en SQLite
            var videojuegos = servicio.Consultar();

            // Mostrar los videojuegos en la lista
            ListaVideojuegos.ItemsSource = videojuegos;

            // Informar la cantidad de registros encontrados
            txtMensaje.Text = "Videojuegos encontrados: " + videojuegos.Count;
        }

        // Registrar un videojuego nuevo
        private void Registrar_Click(object? sender, RoutedEventArgs e)
        {
            try
            {
                // Enviar los datos del formulario al servicio
                servicio.Registrar(
                    txtNombre.Text ?? "",
                    txtPlataforma.Text ?? ""
                );

                // Actualizar la lista después del registro
                CargarVideojuegos();

                // Limpiar los campos del formulario
                Limpiar_Click(sender, e);

                // Mostrar mensaje de confirmación
                txtMensaje.Text = "Videojuego registrado correctamente.";
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje si ocurre un error
                txtMensaje.Text = "Error: " + ex.Message;
            }
        }

        // Modificar los datos de un videojuego seleccionado
        private void Modificar_Click(object? sender, RoutedEventArgs e)
        {
            try
            {
                // Comprobar que exista un videojuego seleccionado
                if (ListaVideojuegos.SelectedItem is not Videojuego videojuego)
                {
                    txtMensaje.Text = "Selecciona un videojuego para modificar.";
                    return;
                }

                // Actualizar los datos en la base de datos
                servicio.Modificar(
                    videojuego.Id,
                    txtNombre.Text ?? "",
                    txtPlataforma.Text ?? ""
                );

                // Actualizar la lista después de modificar
                CargarVideojuegos();

                // Limpiar los campos del formulario
                Limpiar_Click(sender, e);

                // Mostrar mensaje de confirmación
                txtMensaje.Text = "Videojuego modificado correctamente.";
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje si ocurre un error
                txtMensaje.Text = "Error: " + ex.Message;
            }
        }

        // Eliminar un videojuego seleccionado
        private void Eliminar_Click(object? sender, RoutedEventArgs e)
        {
            try
            {
                // Comprobar que exista un videojuego seleccionado
                if (ListaVideojuegos.SelectedItem is not Videojuego videojuego)
                {
                    txtMensaje.Text = "Selecciona un videojuego para eliminar.";
                    return;
                }

                // Eliminar el videojuego de la base de datos
                servicio.Eliminar(videojuego.Id);

                // Actualizar la lista después de eliminar
                CargarVideojuegos();

                // Limpiar los campos del formulario
                Limpiar_Click(sender, e);

                // Mostrar mensaje de confirmación
                txtMensaje.Text = "Videojuego eliminado correctamente.";
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje si ocurre un error
                txtMensaje.Text = "Error: " + ex.Message;
            }
        }

        // Cargar los datos del videojuego seleccionado en los campos
        private void ListaVideojuegos_SelectionChanged(
            object? sender,
            SelectionChangedEventArgs e)
        {
            if (ListaVideojuegos.SelectedItem is Videojuego videojuego)
            {
                // Mostrar el nombre y la plataforma seleccionados
                txtNombre.Text = videojuego.Nombre;
                txtPlataforma.Text = videojuego.Plataforma;
            }
        }

        // Limpiar los campos del formulario y quitar la selección
        private void Limpiar_Click(object? sender, RoutedEventArgs e)
        {
            txtNombre.Text = "";
            txtPlataforma.Text = "";
            ListaVideojuegos.SelectedItem = null;
        }

        // Mostrar todos los videojuegos desde el menú lateral
        private void AllGames_Click(object? sender, RoutedEventArgs e)
        {
            CargarVideojuegos();
            txtMensaje.Text = "Biblioteca actualizada correctamente.";
        }

        // Acceso rápido al formulario de registro
        private void RegistrarMenu_Click(object? sender, RoutedEventArgs e)
        {
            txtNombre.Focus();
            txtMensaje.Text = "Ingresa los datos del nuevo videojuego.";
        }

        // Acceso rápido a la selección de videojuegos para modificar
        private void ModificarMenu_Click(object? sender, RoutedEventArgs e)
        {
            ListaVideojuegos.Focus();
            txtMensaje.Text = "Selecciona un videojuego para modificar.";
        }

        // Actualizar la biblioteca desde el menú lateral
        private void AdministrarMenu_Click(object? sender, RoutedEventArgs e)
        {
            CargarVideojuegos();
            ListaVideojuegos.Focus();
            txtMensaje.Text = "Selecciona un videojuego para administrarlo.";
        }
    }
}


using RegistroVideojuegos.Data;
using RegistroVideojuegos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegistroVideojuegos.Services
{
    public class VideojuegoServicio
    {
        private readonly VideojuegoDAO dao;

        // Constructor
        public VideojuegoServicio()
        {
            dao = new VideojuegoDAO();
            dao.CrearTabla();
        }

        // Registrar videojuego
        public void Registrar(string nombre, string plataforma)
        {
            ValidarDatos(nombre, plataforma);

            Videojuego videojuego = new Videojuego(
                0, nombre.Trim(), plataforma.Trim()
            );

            dao.Agregar(videojuego);
        }

        // Consultar videojuegos
        public List<Videojuego> Consultar()
        {
            return dao.ObtenerTodos();
        }

        // Modificar videojuego
        public void Modificar(int id, string nombre, string plataforma)
        {
            ValidarDatos(nombre, plataforma);

            if (!dao.ObtenerTodos().Any(v => v.Id == id))
            {
                throw new Exception("El videojuego no existe.");
            }

            Videojuego videojuego = new Videojuego(
                id, nombre.Trim(), plataforma.Trim()
            );

            dao.Actualizar(videojuego);
        }

        // Eliminar videojuego
        public void Eliminar(int id)
        {
            if (!dao.ObtenerTodos().Any(v => v.Id == id))
            {
                throw new Exception("El videojuego no existe.");
            }

            dao.Eliminar(id);
        }

        // Validar información
        private void ValidarDatos(string nombre, string plataforma)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre del videojuego es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(plataforma))
            {
                throw new Exception("La plataforma es obligatoria.");
            }
        }
    }
}

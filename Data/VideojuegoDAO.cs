
using Microsoft.Data.Sqlite;
using RegistroVideojuegos.Models;
using System.Collections.Generic;

namespace RegistroVideojuegos.Data
{
    public class VideojuegoDAO
    {
        private readonly string conexion =
            "Data Source=videojuegos.db";

        // Crear la tabla si no existe
        public void CrearTabla()
        {
            using (SqliteConnection con = new SqliteConnection(conexion))
            {
                con.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS Videojuegos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Plataforma TEXT NOT NULL
                )";

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Registrar videojuego
        public void Agregar(Videojuego videojuego)
        {
            using (SqliteConnection con = new SqliteConnection(conexion))
            {
                con.Open();

                string sql = @"INSERT INTO Videojuegos (Nombre, Plataforma)
                               VALUES ($nombre, $plataforma)";

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("$nombre", videojuego.Nombre);
                    cmd.Parameters.AddWithValue("$plataforma", videojuego.Plataforma);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Consultar videojuegos
        public List<Videojuego> ObtenerTodos()
        {
            List<Videojuego> lista = new List<Videojuego>();

            using (SqliteConnection con = new SqliteConnection(conexion))
            {
                con.Open();

                string sql = "SELECT * FROM Videojuegos";

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Videojuego videojuego = new Videojuego(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)
                        );

                        lista.Add(videojuego);
                    }
                }
            }

            return lista;
        }

        // Actualizar videojuego
        public void Actualizar(Videojuego videojuego)
        {
            using (SqliteConnection con = new SqliteConnection(conexion))
            {
                con.Open();

                string sql = @"UPDATE Videojuegos
                               SET Nombre = $nombre,
                                   Plataforma = $plataforma
                               WHERE Id = $id";

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("$id", videojuego.Id);
                    cmd.Parameters.AddWithValue("$nombre", videojuego.Nombre);
                    cmd.Parameters.AddWithValue("$plataforma", videojuego.Plataforma);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar videojuego
        public void Eliminar(int id)
        {
            using (SqliteConnection con = new SqliteConnection(conexion))
            {
                con.Open();

                string sql = "DELETE FROM Videojuegos WHERE Id = $id";

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("$id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

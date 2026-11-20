
namespace RegistroVideojuegos.Models
{
    public class Videojuego
    {
        // Propiedades del videojuego
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Plataforma { get; set; }

        // Constructor
        public Videojuego(int id, string nombre, string plataforma)
        {
            Id = id;
            Nombre = nombre;
            Plataforma = plataforma;
        }
    }
}

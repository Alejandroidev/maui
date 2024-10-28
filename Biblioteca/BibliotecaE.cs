namespace Entidad
{
    public class BibliotecaE
    {
        public static List<Libro> Libros { get; set; } = new List<Libro>();
        public static List<Usuario> Usuario { get; set; } = new List<Usuario>();

        public BibliotecaE() { }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            Usuario.Add(usuario);
        }

        public List<Libro> GetBooks() => Libros;

        public List<Usuario> GetUsers() => Usuario;
    }
}
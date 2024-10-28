namespace Entidad
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int CantidadDeCopias { get; set; }

        public void Prestar()
        {
            this.CantidadDeCopias = this.CantidadDeCopias - 1;
        }

        public void Devolver()
        {
            this.CantidadDeCopias = this.CantidadDeCopias + 1;
        }

        public Libro(string titulo, string autor, string iSBN, int cantidadDeCopias)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            CantidadDeCopias = cantidadDeCopias;
        }
    }
}

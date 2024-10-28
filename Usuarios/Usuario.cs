using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public static List<Libro> LibrosPrestados { get; set; } = new List<Libro>();


        public void PrestarLibro(Libro libro) 
        {
            LibrosPrestados.Add(libro);
        }

        public void devolverLibro(Libro libro)
        {
            LibrosPrestados.Remove(libro);
        }


        public Usuario(string nombre, int id, List<Libro> librosPrestados)
        {
            Nombre = nombre;
            Id = id;
            LibrosPrestados = librosPrestados;
        }

        public Usuario(string nombre, int id)
        {
            Nombre = nombre;
            Id = id;
        }
    }
}

using Entidad;
using System.Collections.ObjectModel;
using System.Linq;

namespace MauiApp1
{
    public partial class Biblioteca : ContentPage
    {
        BibliotecaE bb = new();
        public Biblioteca()
        {
            InitializeComponent();
        }
        public ObservableCollection<Usuario> Usuarios { get; set; } = new ObservableCollection<Usuario>();
        public ObservableCollection<Libro> Libros { get; set; } = new ObservableCollection<Libro>();

        private async void Home(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
            BindingContext = this;
        }

        private void ConsultarUsuarios(object sender, EventArgs e)
        {
       
            var usuarios = bb.GetUsers();
          
            foreach (var item in usuarios)
            {
                Usuarios.Add(item);
            }
            UsuariosCollectionView.ItemsSource = Usuarios;

        }

        private void ConsultarLibros(object sender, EventArgs e)
        {
            
            var libros = bb.GetBooks();
           
            foreach (var item in libros)
            {
                Libros.Add(item);
            }

            LibrosCollectionView.ItemsSource = Libros;

        }


        private async void PrestarClic(object sender, EventArgs e) 
        {
            string idUsuario = UsurioEntry.Text;
            string isbn = ISBNEntry.Text;

            var user = bb.GetUsers().ToList().Where(a => a.Id.ToString().Contains(idUsuario)).FirstOrDefault();
            var book = bb.GetBooks().ToList().Where(a => a.ISBN.Contains(isbn)).FirstOrDefault();
            if (book.CantidadDeCopias != 0) 
            {
                book.CantidadDeCopias--;
                user.PrestarLibro(book);
                await DisplayAlert("libro prestado", $"libro prestado a {user.Nombre} con el titulo de {book.Titulo} de {book.Autor}", "OK");
            }
            else
            {
                await DisplayAlert("no hay copias disponibles", $"no hay copias disponibles", "OK");

            }





        }

        private async void RetornarClic(object sender, EventArgs e)
        {
            string idUsuario = UsurioEntry.Text;
            string isbn = ISBNEntry.Text;

            var user = bb.GetUsers().ToList().Where(a => a.Id.ToString().Contains(idUsuario)).FirstOrDefault();
            var book = bb.GetBooks().ToList().Where(a => a.ISBN.Contains(isbn)).FirstOrDefault();

            user.devolverLibro(book);
            book.CantidadDeCopias++;
            await DisplayAlert("se retorno el libro", $"se retorna a biblioteca el libro {book.Titulo} de {book.Autor} cantidad de copias diponibles {book.CantidadDeCopias}", "OK");
        }
    }

}

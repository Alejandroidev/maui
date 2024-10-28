using Entidad;

namespace MauiApp1
{
    public partial class Libros : ContentPage
    {
        int count = 0;

        public Libros()
        {
            InitializeComponent();
        }

        private async void Home(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void AddBook(object sender, EventArgs e) 
        {
            string titulo = tituloEntry.Text;
            string autor = autorEntry.Text;
            string isbn = isbnEntry.Text;
            int cantidadDeCopias = int.Parse( cantidadDeCopiasEntry.Text);
            Libro libro = new Libro(titulo,autor,isbn,cantidadDeCopias);
            BibliotecaE biblioteca = new BibliotecaE();
            biblioteca.AgregarLibro(libro);
            await DisplayAlert("guardado", $"se guardo en biblioteca {titulo}","ok");
        }
    }

}

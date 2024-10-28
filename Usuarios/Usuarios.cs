using Entidad;

namespace MauiApp1
{
    public partial class Usuarios : ContentPage
    {
        int count = 0;

        public Usuarios()
        {
            InitializeComponent();
        }

        private async void Home(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void AddUserClick(object sender, EventArgs e) 
        {
            string nombre = NombreEntry.Text;
            int id = int.Parse(IdEntry.Text);
            Usuario usuario = new Usuario(nombre,id);
            BibliotecaE biblioteca = new BibliotecaE();
            biblioteca.AgregarUsuario(usuario);
            await DisplayAlert("guardado", $"se guardo en biblioteca usuario {usuario.Nombre}", "ok");

        }
    }

}

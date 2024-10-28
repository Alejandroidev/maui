namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Libros());
        }

        private async void UsuariosClick(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Usuarios());
        }

        private async void BibliotecaClick(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Biblioteca());
        }

    }

}

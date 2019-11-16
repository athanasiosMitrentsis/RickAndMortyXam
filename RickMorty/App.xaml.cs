using Xamarin.Forms;
using RickMorty.Services;

namespace RickMorty
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<CharacterService>();
            MainPage = new AppShell();
        }

    }
}

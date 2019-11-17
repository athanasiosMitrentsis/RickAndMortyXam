using Xamarin.Forms;
using RickMorty.Services;
using Xamarin.Forms.Xaml;

namespace RickMorty
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<CharacterService>();
            DependencyService.Register<LocationService>();

            MainPage = new AppShell();
        }

    }
}

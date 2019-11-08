using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RickMorty.Services;
using RickMorty.Views;

namespace RickMorty
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<CharacterService>();
            MainPage = new AppShell();
        }

    }
}

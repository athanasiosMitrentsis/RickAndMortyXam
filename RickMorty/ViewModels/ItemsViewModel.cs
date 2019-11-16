using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using RickMorty.Models;
using RickMorty.Models.Dtos;

namespace RickMorty.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<CharacterDto> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public Command LoadNext { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<CharacterDto>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            LoadNext = new Command(async () => await LoadNextImpl());

        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await ICharacterService.GetCharacters();

                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async Task LoadNextImpl()
        {
            IsBusy = true;

            var fakeNextUri = "";

            var nextItems = await ICharacterService.Next(fakeNextUri);

            foreach(var character in nextItems)
            {
                Items.Add(character);
            }

            IsBusy = false;
        }
    }
}
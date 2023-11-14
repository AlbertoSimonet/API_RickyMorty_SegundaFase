using API_RickyMorty.Service;
using API_RickyMorty.ViewModel;

namespace API_RickyMorty
{
    public partial class MainPage : ContentPage
    {
        private readonly CharactersViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new CharactersViewModel(new CharacterApiService());
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadCharacters();
        }

        private async void LoadCharacters()
        {
            await _viewModel.LoadCharactersAsync();
        }
    }
}
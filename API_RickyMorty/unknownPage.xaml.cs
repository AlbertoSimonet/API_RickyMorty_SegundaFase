using API_RickyMorty.Service;
using API_RickyMorty.ViewModel;

namespace API_RickyMorty;

public partial class unknownPage : ContentPage
{
    private readonly OriginViewModel _viewModel;

    public unknownPage()
    {
        InitializeComponent();
        _viewModel = new OriginViewModel(new CharacterApiService());
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadCharacters();
    }

    private async void LoadCharacters()
    {
        await _viewModel.LoadCharactersAsync("unknown");
    }
}
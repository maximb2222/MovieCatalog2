using MovieCatalog.ViewModels;

namespace MovieCatalog.Views;

public partial class MoviesListPage : ContentPage
{
    public MoviesListPage()
    {
        InitializeComponent();
        BindingContext = App.MainViewModel;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
            return;

        await Navigation.PushAsync(new MovieDetailPage());

        ((CollectionView)sender).SelectedItem = null;
    }
}
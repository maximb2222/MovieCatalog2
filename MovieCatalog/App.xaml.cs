
using MovieCatalog.ViewModels;
using MovieCatalog.Views;

namespace MovieCatalog;

public partial class App : Application
{
    public static MovieListViewModel MainViewModel { get; private set; } = null!;

    public App()
    {
        InitializeComponent();

        MainViewModel = new MovieListViewModel();
        MainPage = new NavigationPage(new MoviesListPage());
    }
}
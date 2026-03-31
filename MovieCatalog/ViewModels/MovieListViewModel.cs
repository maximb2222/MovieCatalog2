using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Windows.Input;
using MovieCatalog.Models;

namespace MovieCatalog.ViewModels;

public class MovieListViewModel : BaseViewModel
{
    private MovieViewModel? _selectedMovie;

    public ObservableCollection<MovieViewModel> Movies { get; } = new();

    public MovieViewModel? SelectedMovie
    {
        get => _selectedMovie;
        set => SetProperty(ref _selectedMovie, value);
    }

    public ICommand DeleteMovieCommand { get; }

    public MovieListViewModel()
    {
        LoadMovies();
        DeleteMovieCommand = new Command<MovieViewModel>(DeleteMovie);
    }

    private void DeleteMovie(MovieViewModel movie)
    {
        if (movie != null && Movies.Contains(movie))
        {
            Movies.Remove(movie);
        }
    }

    private void LoadMovies()
    {
        var moviesList = new List<Movie>
        {
            new Movie { Title = "Матрица", Year = 1999, Director = "Вачовски", Genre = "Фантастика" },
            new Movie { Title = "Начало", Year = 2010, Director = "Нолан", Genre = "Триллер" },
            new Movie { Title = "Криминальное чтиво", Year = 1994, Director = "Тарантино", Genre = "Криминал" },
            new Movie { Title = "Побег из Шоушенка", Year = 1994, Director = "Дарабонт", Genre = "Драма" }
        };

        foreach (var movie in moviesList)
        {
            Movies.Add(new MovieViewModel(movie));
        }
    }
}
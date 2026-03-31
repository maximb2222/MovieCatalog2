using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieCatalog.Models;

namespace MovieCatalog.ViewModels;

public class MovieViewModel : BaseViewModel
{
    private Movie _movie;

    public MovieViewModel(Movie movie)
    {
        _movie = movie;
    }

    public string Title => _movie.Title;
    public int Year => _movie.Year;
    public string Director => _movie.Director;
    public string Genre => _movie.Genre;
}
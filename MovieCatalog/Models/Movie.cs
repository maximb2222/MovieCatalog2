using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Models;

public class Movie
{
    public string Title { get; set; } = "";
    public int Year { get; set; }
    public string Director { get; set; } = "";
    public string Genre { get; set; } = "";
}
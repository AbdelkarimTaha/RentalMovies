using MoviesWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesWebsite.ViewModels
{
    public class MovieFormViewModel
    {
        public string Title { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
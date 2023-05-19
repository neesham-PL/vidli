using System.Collections.Generic;
using vidli.Models;

namespace vidli.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        //we can also use List but we don't need all the functionalities add,remove, only iteration to be used in new customer page
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";
                return "New Movie";

            }
        }
    }
}


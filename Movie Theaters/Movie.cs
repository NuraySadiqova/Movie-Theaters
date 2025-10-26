using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theaters
{
    internal class Movie:Base
    {
        public string Director { get; set; }
        public Genre Genre { get; set; }
        public int AgeLimit { get; set; }

        private static int _idCounter = 1;

        public Movie(string name, string director, Genre genre, int ageLimit)
        {
            Id = _idCounter;
            Name = name;
            Director = director;
            Genre = genre;
            AgeLimit = ageLimit;
        }
    }


}

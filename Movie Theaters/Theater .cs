using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theaters
{
    internal class Theater:Base
    {
           private static int _idCounter = 1;
            private List<Movie> _movies = new List<Movie>();

            public Theater(string name)
            {
                Id = _idCounter;
                Name = name;
            }

            public void AddMovie(Movie movie)
            {
                if (_movies.Any(m => m.Id == movie.Id))
                {
                    Console.WriteLine("Bu film artıq repertuarda var!");
                    return;
                }
                _movies.Add(movie);
                Console.WriteLine("Film repertuara əlavə olundu!");
            }

            public void ListAllMovies()
            {
                if (_movies.Count == 0)
                {
                    Console.WriteLine("Repertuarda film yoxdur.");
                    return;
                }

                Console.WriteLine($"\n {Name} Teatrının Repertuarı:");
                foreach (var movie in _movies)
                {
                    Console.WriteLine(movie);
                }
            }

            public void RemoveMovie(Movie movie)
            {
                if (_movies.Remove(movie))
                {
                    Console.WriteLine("Film repertuardan çıxarıldı!");
                }
                else
                {
                    Console.WriteLine("Bu film repertuarda yoxdur!");
                }
            }

            public override string ToString()
            {
                return $"{Id}. {Name}";
            }
        
    }

}


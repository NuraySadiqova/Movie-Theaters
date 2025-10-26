using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theaters
{
    internal class Genre:Base 
    {
            private static int _idCounter = 1;

            public Genre(string name)
            {
                Id = _idCounter;
                Name = name;
            }

            public override string ToString()
            {
                return( $"{Id}.{Name}");
            }
        
    }

}


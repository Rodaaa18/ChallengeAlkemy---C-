using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY.Entities
{
    public class Genre
    {
        public Genre()
        {
            MovieSerie = new HashSet<MovieSerie>();
        }
        public int IdGenre { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<MovieSerie> MovieSerie { get; set; }
    }
}

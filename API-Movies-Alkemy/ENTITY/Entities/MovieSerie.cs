using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY.Entities
{
    public class MovieSerie
    {
        public int IdMovieSerie { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public int Qualification { get; set; }
        public int IdCharacter { get; set; }
        public Character idCharacter { get; set; }
        public int IdGenre { get; set; }
        public Genre idGenre { get; set; }
    }
}

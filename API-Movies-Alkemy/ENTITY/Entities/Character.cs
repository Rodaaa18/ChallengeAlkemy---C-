using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY.Entities
{
    public class Character
    {
        public Character()
        {
            MovieSerie = new HashSet<MovieSerie>();
        }
        public int IdCharacter { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string History { get; set; }
        public virtual ICollection<MovieSerie> MovieSerie { get; set; }
    }
}

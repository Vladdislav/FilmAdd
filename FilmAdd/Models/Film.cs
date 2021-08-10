using System;
using System.Collections.Generic;
using System.Text;

namespace FilmAdd.Models
{
    public class Film
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string ImageURL { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

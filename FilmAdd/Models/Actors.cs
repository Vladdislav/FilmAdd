using System;
using System.Collections.Generic;
using System.Text;

namespace FilmAdd.Models
{
    public class Actors
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public override string ToString()
        {
            return FirstName;
        }
    }
}

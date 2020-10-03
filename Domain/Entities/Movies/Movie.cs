using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Movies
{
    public class Movie
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public float Rate { get; set; }
    }
}

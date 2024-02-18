using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFlix.Models;

namespace MovieFlix_dotnet.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using MovieFlix_dotnet.Models;

namespace MovieFlix.Models
{

    public class Movie
    {
        [Key()]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public int? Year { get; set; }
        public string? ImgUrl { get; set; }
        public string? Synopsis { get; set; }
        public int? GenreId { get; set; }
        public Genre? Genre { get; set; }

    }

}
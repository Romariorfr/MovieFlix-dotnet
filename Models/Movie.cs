namespace MovieFlix.Models
{

    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public int? Year { get; set; }
        public string? ImgUrl { get; set; }
        public string? Synopsis { get; set; }

    }

}
using Microsoft.AspNetCore.Mvc;
using MovieFlix.Models;

namespace MovieFlix_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> Movies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1,Title = "O espetacular Homem Aranha", ImgUrl = "url_filme", SubTitle = "O sensor poderoso", Synopsis = "", Year = 2002},
                new Movie { Id = 2,Title = "O Homem sem Sombra", ImgUrl = "url_filme", SubTitle = "fuja", Synopsis = "", Year = 2002}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Movies());
        }

        [HttpPost]
        public IActionResult Post(Movie movie)
        {
            var movies = Movies();
            movies.Add(movie);
            return Ok(movies);

        }

    }
}

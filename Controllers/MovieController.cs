using Microsoft.AspNetCore.Mvc;
using MovieFlix.Models;
using MovieFlix_dotnet.Repository;

namespace MovieFlix_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieRepository _movieRepository;
        public MovieController(IMovieRepository repository)
        {
            _movieRepository = repository;
        }
        

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = await _movieRepository.FindMovies();
            return movies.Any() ? Ok(movies) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var movie = await _movieRepository.FindMovieById(id);
            return movie != null ? Ok(movie) : NotFound("Usuário não encontrado");
        }


        [HttpPost]
        public async Task<IActionResult> Post(Movie movie)
        {
            _movieRepository.AddMovie(movie);
            return await _movieRepository.SaveChangesAsync() ? Ok("Filme Adicionado com sucesso") : BadRequest("Erro ao salvar o filme");

        }

    }
}

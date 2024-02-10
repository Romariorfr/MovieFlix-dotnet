using Microsoft.EntityFrameworkCore;
using MovieFlix.Models;
using MovieFlix_dotnet.Data;

namespace MovieFlix_dotnet.Repository
{
    public class MovieRepository : IMovieRepository        
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context )
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Add(movie);
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> FindMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> FindMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public void UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

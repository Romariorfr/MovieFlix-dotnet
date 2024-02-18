using Microsoft.EntityFrameworkCore;
using MovieFlix.Models;
using MovieFlix_dotnet.Data;

namespace MovieFlix_dotnet.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MyContext _context;

        public MovieRepository(MyContext context)
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Add(movie);
        }

        public async Task<Movie?> FindMovieById(int id)
        {
            return await _context.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Movie>> FindMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public void UpdateMovie(Movie movie)
        {
            _context.Update(movie);

        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void DeleteMovie(Movie movie)
        {
            _context.Remove(movie);
        }

    }
}

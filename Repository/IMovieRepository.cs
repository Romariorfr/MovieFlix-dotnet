using MovieFlix.Models;

namespace MovieFlix_dotnet.Repository
{
    public interface IMovieRepository
    {
        Task <IEnumerable<Movie>> FindMovies();

        Task<Movie> FindMovieById(int id);

        void AddMovie(Movie movie);

        void UpdateMovie(Movie movie);

        void DeleteMovie(Movie movie);

        Task<bool> SaveChangesAsync();
       



    }
}

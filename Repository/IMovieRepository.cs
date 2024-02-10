using MovieFlix.Models;

namespace MovieFlix_dotnet.Repository
{
    public interface IMovieRepository
    {
        Task <IEnumerable<Movie>> FindMovies();

        Task<IEnumerable<Movie>> FindMovieById(int id);

        void AddMovie(Movie movie);

        void UpdateMovie(Movie movie);

        void DeleteMovie(int id);

        Task<bool> SaveChangesAsync();
       



    }
}

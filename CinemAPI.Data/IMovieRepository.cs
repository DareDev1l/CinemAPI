using CinemAPI.Models.Contracts.Movie;

namespace CinemAPI.Data
{
    public interface IMovieRepository
    {
        IMovie GetByNameAndDuration(string name, short duration);

        void Insert(IMovieCreation movie);
    }
}
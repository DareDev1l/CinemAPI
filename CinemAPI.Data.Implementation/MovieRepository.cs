using CinemAPI.Models.Contracts.Movie;

namespace CinemAPI.Data.Implementation
{
    public class MovieRepository : IMovieRepository
    {
        public IMovie GetById(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public IMovie GetByNameAndDuration(string name, short duration)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(IMovieCreation movie)
        {
            throw new System.NotImplementedException();
        }
    }
}
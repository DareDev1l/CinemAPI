using CinemAPI.Models.Contracts.Movie;

namespace CinemAPI.Models
{
    public class Movie : IMovie, IMovieCreation
    {
        public Movie()
        {
        }

        public Movie(string name, short durationInMinutes)
        {
            this.Name = name;
            this.DurationMinutes = durationInMinutes;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public short DurationMinutes { get; set; }
    }
}
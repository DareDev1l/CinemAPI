using CinemAPI.Models;
using System.Data.Entity;

namespace CinemAPI.Data.EF
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
            : base("CinemaDbContext")
        {
        }

        public virtual IDbSet<Cinema> Cinemas { get; set; }

        public virtual IDbSet<Room> Rooms { get; set; }

        public virtual IDbSet<Movie> Movies { get; set; }

        public virtual IDbSet<Projection> Projections { get; set; }
    }
}
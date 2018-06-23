using CinemAPI.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CinemAPI.Data.EF
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
            : base("CinemaDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CinemaDbContext, MigrationConfiguration>());
        }

        public virtual IDbSet<Cinema> Cinemas { get; set; }

        public virtual IDbSet<Room> Rooms { get; set; }

        public virtual IDbSet<Movie> Movies { get; set; }

        public virtual IDbSet<Projection> Projections { get; set; }
    }
}
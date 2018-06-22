using CinemAPI.Data;
using CinemAPI.Models;
using CinemAPI.Models.Contracts.Movie;
using CinemAPI.Models.Contracts.Projection;
using CinemAPI.Models.Input.Projection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CinemAPI.Controllers
{
    public class ProjectionController : ApiController
    {
        private readonly IProjectionRepository projectRepo;
        private readonly IMovieRepository movieRepo;

        public ProjectionController(IProjectionRepository projectRepo, IMovieRepository movieRepo)
        {
            this.projectRepo = projectRepo;
            this.movieRepo = movieRepo;
        }

        [HttpPost]
        public IHttpActionResult Create(ProjectionCreationModel model)
        {
            IProjection projection = projectRepo.Get(model.MovieId, model.RoomId, model.StartDate);

            if (projection != null)
            {
                return BadRequest("Projection already exists");
            }

            // TODO: Add validations for cinema, room and movie existing
            IEnumerable<IProjection> movieProjectionsInRoom = projectRepo.GetActiveProjections(model.RoomId);
            
            IProjection previousProjection = movieProjectionsInRoom.Where(x => x.StartDate < model.StartDate)
                                                                        .OrderByDescending(x => x.StartDate)
                                                                        .FirstOrDefault();

            if (previousProjection != null)
            {
                IMovie previousProjectionMovie = movieRepo.GetById(previousProjection.MovieId);

                DateTime previousProjectionEnd = previousProjection.StartDate.AddMinutes(previousProjectionMovie.DurationMinutes);

                if (previousProjectionEnd >= model.StartDate)
                {
                    return BadRequest($"Projection overlaps with previous one: {previousProjectionMovie.Name} at {previousProjection.StartDate}");
                }
            }

            IProjection nextProjection = movieProjectionsInRoom.Where(x => x.StartDate > model.StartDate)
                                                                       .OrderBy(x => x.StartDate)
                                                                       .FirstOrDefault();

            if (nextProjection != null)
            {
                IMovie curMovie = movieRepo.GetById(model.MovieId);
                IMovie nextProjectionMovie = movieRepo.GetById(nextProjection.MovieId);

                DateTime curProjectionEndTime = model.StartDate.AddMinutes(curMovie.DurationMinutes);

                if (curProjectionEndTime >= nextProjection.StartDate)
                {
                    return BadRequest($"Projection overlaps with next one: {nextProjectionMovie.Name} at {nextProjection.StartDate}");
                }
            }

            projectRepo.Insert(new Projection(model.MovieId, model.RoomId, model.StartDate));

            return Ok();
        }
    }
}
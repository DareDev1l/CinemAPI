using CinemAPI.Data;
using CinemAPI.Models;
using CinemAPI.Models.Input.Cinema;
using System.Web.Http;

namespace CinemAPI.Controllers
{
    public class CinemaController : ApiController
    {
        private readonly ICinemaRepository cinemaRepo;

        public CinemaController(ICinemaRepository cinemaRepo)
        {
            this.cinemaRepo = cinemaRepo;
        }

        public IHttpActionResult Create(CinemaCreationModel model)
        {
            Cinema cinema = cinemaRepo.GetByNameAndAddress(model.Name, model.Address);

            if (cinema == null)
            {
                cinemaRepo.Insert(cinema);

                return Ok();
            }

            return BadRequest("Cinema already exists");
        }
    }
}
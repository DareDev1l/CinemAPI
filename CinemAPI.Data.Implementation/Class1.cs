using CinemAPI.Models.Contracts.Cinema;

namespace CinemAPI.Data.Implementation
{
    public class CinemaRepository : ICinemaRepository
    {
        public ICinema GetByNameAndAddress(string name, string address)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(ICinemaCreation cinema)
        {
            throw new System.NotImplementedException();
        }
    }
}
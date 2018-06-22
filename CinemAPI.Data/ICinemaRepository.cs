using CinemAPI.Models;

namespace CinemAPI.Data
{
    public interface ICinemaRepository : IRepository<Cinema>
    {
        Cinema GetByNameAndAddress(string name, string address);
    }
}

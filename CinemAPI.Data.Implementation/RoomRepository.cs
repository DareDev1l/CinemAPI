using CinemAPI.Models.Contracts.Room;

namespace CinemAPI.Data.Implementation
{
    public class RoomRepository : IRoomRepository
    {
        public IRoom GetByCinemaAndNumber(int cinemaId, int number)
        {
            throw new System.NotImplementedException();
        }

        public IRoom GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(IRoomCreation room)
        {
            throw new System.NotImplementedException();
        }
    }
}
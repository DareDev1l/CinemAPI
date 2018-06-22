using CinemAPI.Models.Contracts.Room;

namespace CinemAPI.Data
{
    public interface IRoomRepository
    {
        void Insert(IRoomCreation room);

        IRoom GetByCinemaAndNumber(int cinemaId, int number);
    }
}
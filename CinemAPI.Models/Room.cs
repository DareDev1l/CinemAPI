using CinemAPI.Models.Contracts.Room;

namespace CinemAPI.Models
{
    public class Room : IRoom, IRoomCreation
    {
        public Room()
        {
        }

        public Room(int number, short seatsPerRow, short rows, int cinemaId)
        {
            this.Number = number;
            this.SeatsPerRow = seatsPerRow;
            this.Rows = rows;
            this.CinemaId = cinemaId;
        }

        public int Id { get; set; }

        public int Number { get; set; }

        public short SeatsPerRow { get; set; }

        public short Rows { get; set; }

        public int CinemaId { get; set; }
    }
}
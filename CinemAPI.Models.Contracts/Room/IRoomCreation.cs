namespace CinemAPI.Models.Contracts.Room
{
    public interface IRoomCreation
    {
        int Number { get; set; }

        short SeatsPerRow { get; set; }

        short Rows { get; set; }

        int CinemaId { get; set; }
    }
}
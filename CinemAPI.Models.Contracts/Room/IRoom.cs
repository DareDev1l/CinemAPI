namespace CinemAPI.Models.Contracts.Room
{
    public interface IRoom
    {
       int Id { get; set; }

       int CinemaId { get; set; }

       int Number { get; set; }

       short SeatsPerRow { get; set; }

       short Rows { get; set; }
    }
}
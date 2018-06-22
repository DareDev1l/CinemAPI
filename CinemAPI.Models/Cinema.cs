using CinemAPI.Models.Contracts.Cinema;

namespace CinemAPI.Models
{
    public class Cinema : ICinema, ICinemaCreation
    {
        public Cinema()
        {

        }

        public Cinema(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
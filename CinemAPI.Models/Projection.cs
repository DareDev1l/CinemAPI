using System;

namespace CinemAPI.Models
{
    public class Projection
    {
        public short RoomId { get; set; }

        public short MovieId { get; set; }

        public DateTime StartDate { get; set; }
    }
}
using System;

namespace CinemAPI.Models
{
    public class Projection
    {
        public long Id { get; set; }

        public int RoomId { get; set; }

        public int MovieId { get; set; }

        public DateTime StartDate { get; set; }
    }
}
using CinemAPI.Models.Contracts.Projection;
using System;
using System.Collections.Generic;

namespace CinemAPI.Data.Implementation
{
    public class ProjectionRepository : IProjectionRepository
    {
        public IProjection Get(int movieId, int roomId, DateTime startDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProjection> GetActiveProjections(int roomId)
        {
            throw new NotImplementedException();
        }

        public void Insert(IProjectionCreation projection)
        {
            throw new NotImplementedException();
        }
    }
}
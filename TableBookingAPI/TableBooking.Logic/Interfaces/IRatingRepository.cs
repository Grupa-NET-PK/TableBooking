﻿using TableBooking.Model.Models;

namespace TableBooking.Logic.Interfaces
{
    public interface IRatingRepository : IGenericRepository<Rating>
    {
        Task<IEnumerable<Rating>> GetRatingsAsync(Guid restaurantId);
    }
}

using System;
using System.Collections.Generic;
using Umi.API.Models;

namespace Umi.API.Services
{
    public interface ITouristRouteRepository
    {
        // from DB, get all routes
        IEnumerable<TouristRoute> GetTouristRoutes();
        TouristRoute GetTouristRoute(Guid id);
    }
}
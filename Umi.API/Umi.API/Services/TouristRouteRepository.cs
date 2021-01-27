using System;
using System.Collections.Generic;
using System.Linq;
using Umi.API.Database;
using Umi.API.Models;

namespace Umi.API.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {
        private readonly AppDbContext _context;

        public TouristRouteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _context.TouristRoutes;
        }

        public TouristRoute GetTouristRoute(Guid id)
        {
            return _context.TouristRoutes.FirstOrDefault(n => n.Id == id);
        }
    }
}
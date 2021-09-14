using MyTourismSite.Database;
using MyTourismSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTourismSite.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {

        private readonly AddDbContext _context;
        public TouristRouteRepository(AddDbContext context)
        {
            _context = context;

        }
        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _context.TouristRoutes.FirstOrDefault(n => n.Id==touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _context.TouristRoutes;
        }
    }
}

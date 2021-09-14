using MyTourismSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTourismSite.Services
{
    public class MockTouristRouteRepository : ITouristRouteRepository
    {
        private List<TouristRoute> _routes;
        public MockTouristRouteRepository()
        {
            if (_routes == null)
            {
                InitializeTouristRoutes();
            }
        }
        private void InitializeTouristRoutes()
        {
            _routes = new List<TouristRoute>
            {
                new TouristRoute
                {
                    Id=Guid.NewGuid(),
                    Title="黄山",
                    Description="黄山真好玩",
                    OriginalPrice=1200,
                    Feature="<p>吃住行游购娱</p>",
                    Fees="<p>交通费用自理</p>",
                    Notes="<p>小心危险</p>"
                },
                new TouristRoute
                {
                    Id=Guid.NewGuid(),
                    Title="泰山",
                    Description="泰山真好玩",
                    OriginalPrice=1100,
                    Feature="<p>吃住行游购娱嫖</p>",
                    Fees="<p>包交通费</p>",
                    Notes="<p>不要小心危险</p>"
                }
            };
        }
        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _routes.FirstOrDefault(n => n.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }
    }
}

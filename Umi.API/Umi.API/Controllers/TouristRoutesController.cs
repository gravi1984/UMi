using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Umi.API.Services;

namespace Umi.API.Controllers
{
    [Route("api/TouristRoutes")]
    public class TouristRoutesController : Controller
    {
        private ITouristRouteRepository _touristRouteRepository;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            _touristRouteRepository = touristRouteRepository;
        }

        [HttpGet]
        public IActionResult GetTouristRoutes()
        {
            var routes = _touristRouteRepository.GetTouristRoutes();
            return Ok(routes);

        }
        

    }
}
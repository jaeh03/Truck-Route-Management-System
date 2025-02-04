using JH_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using Route = JH_LAB1.Models.Route;

namespace JH_LAB1.WebServiceController
{
    [Route("route/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private IRouteRepository route;

        // Constructor to inject the IRouteRepository interface dependency
        public RouteController(IRouteRepository route)
        {
            this.route = route;
        }

        // GET: route/RouteController
        // Returns all routes
        [HttpGet]
        public IEnumerable<Route> Get() => route.Routes;

        // GET: route/RouteController/id
        // Returns a single route with the given id
        [HttpGet("{id}")]
        public ActionResult<Route> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request");
            }
            return Ok(route[id]);
        }

        // POST: route/RouteController
        // Adds a new route to the repository
        [HttpPost]
        public Route Post([FromBody] Route routeUsed)
        =>
            route.AddRoute(new Route
            {
                RouteID = routeUsed.RouteID,
                route_name = routeUsed.route_name,
                r_length = routeUsed.r_length,
                r_pay_per_km = routeUsed.r_pay_per_km
            });

        // PUT: route/RouteController
        // Updates an existing route in the repository
        [HttpPut]
        public Route Put([FromBody] Route routeUsed) =>
            route.UpdateRoute(routeUsed);

        // DELETE: route/RouteController/id
        // Deletes an existing route from the repository
        [HttpDelete("{id}")]
        public void Delete(int id) => route.DeleteRoute(id);
    }
}

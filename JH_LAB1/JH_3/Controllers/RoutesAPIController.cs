using Microsoft.AspNetCore.Mvc;
using JH_LAB1.Models;
using Route = JH_LAB1.Models.Route;

namespace JH_3.Controllers
{
    [Route("routes/[controller]")]
    [ApiController]
    public class RoutesAPIController : ControllerBase
    {
        private IRouteRepository route;

        public RoutesAPIController(IRouteRepository route)
        {
            this.route = route;
        }

        [HttpGet]
        public IEnumerable<Route> Get() => route.Routes;

        [HttpGet("{id}")]
        public ActionResult<Route> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request");
            }
            return Ok(route[id]);
        }

        [HttpPost]
        public Route Post([FromBody] Route router)
            =>
            route.AddRoute(new Route
            {
                RouteID = router.RouteID,
                route_name = router.route_name,
                r_length = router.r_length,
                r_pay_per_km = router.r_pay_per_km
            });

        [HttpPut]
        public Route Put([FromBody] Route router) =>
            route.UpdateRoute(router);

        [HttpDelete("{id}")]
        public void Delete(int id) => route.DeleteRoute(id);
    }
}

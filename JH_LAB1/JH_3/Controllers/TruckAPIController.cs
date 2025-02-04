using JH_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace JH_3.Controllers
{
    [Route("api/trucks")]
    [ApiController]
    public class TruckAPIController : ControllerBase
    {
        private ITruckRepository truck;

        public TruckAPIController(ITruckRepository truck)
        {
            this.truck = truck;
        }

        [HttpGet]
        public IEnumerable<Truck> Get() => truck.Trucks;

        [HttpGet("{id}")]
        public ActionResult<Truck> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request");
            }
            return Ok(truck[id]);
        }

        [HttpPost]
        public Truck Post([FromBody] Truck truckUsed)
            =>
            truck.AddTruck(new Truck
            {
                Truck_ID = truckUsed.Truck_ID,
                t_model = truckUsed.t_model,
                t_make = truckUsed.t_make,
                RouteID = truckUsed.RouteID,
            });

        [HttpPut]
        public Truck Put([FromBody] Truck truckUsed) =>
                truck.UpdateTruck(truckUsed);

        [HttpDelete("{id}")]
        public void Delete(int id) => truck.DeleteTruck(id);

    }
}

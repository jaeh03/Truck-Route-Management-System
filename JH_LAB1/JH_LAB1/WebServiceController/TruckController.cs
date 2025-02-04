using JH_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using Route = JH_LAB1.Models.Route;

namespace JH_LAB1.WebServiceController
{
    [Route("truck/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private ITruckRepository truck;

        // Constructor to inject the ITruckRepository interface dependency
        public TruckController(ITruckRepository truck)
        {
            this.truck = truck;
        }

        // GET: truck/TruckController
        // Returns all trucks
        [HttpGet]
        public IEnumerable<Truck> Get() => truck.Trucks;

        // GET: truck/TruckController/id
        // Returns a single truck with the given id
        [HttpGet("{id}")]
        public ActionResult<Truck> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request");
            }
            return Ok(truck[id]);
        }

        // POST: truck/TruckController
        // Adds a new truck to the repository
        [HttpPost]
        public Truck Post([FromBody] Truck truckUsed)
        =>
            truck.AddTruck(new Truck
            {
                Truck_ID = truckUsed.Truck_ID,
                t_model = truckUsed.t_model,
                t_make = truckUsed.t_make,
                RouteID = truckUsed.RouteID
            });

        // PUT: truck/TruckController
        // Updates an existing truck in the repository
        [HttpPut]
        public Truck Put([FromBody] Truck truckUsed) =>
            truck.UpdateTruck(truckUsed);

        // DELETE: truck/TruckController/id
        // Deletes an existing truck from the repository
        [HttpDelete("{id}")]
        public void Delete(int id) => truck.DeleteTruck(id);
    }
}

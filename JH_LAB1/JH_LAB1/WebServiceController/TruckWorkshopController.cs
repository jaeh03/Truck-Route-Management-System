using JH_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using Route = JH_LAB1.Models.Route;

namespace JH_LAB1.WebServiceController
{
    [Route("truckworkshop/[controller]")]
    [ApiController]
    public class TruckWorkshopController : ControllerBase
    {
        private ITruckWorkshopRepository truckWorkshop;

        public TruckWorkshopController(ITruckWorkshopRepository truckWorkshop)
        {
            this.truckWorkshop = truckWorkshop;
        }

        [HttpGet]
        public IEnumerable<TruckWorkshop> Get() => truckWorkshop.TruckWorkshops;

        [HttpGet("{id}")]
        public ActionResult<TruckWorkshop> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request");
            }
            return Ok(truckWorkshop[id]);
        }

        [HttpPost]
        public TruckWorkshop Post([FromBody] TruckWorkshop truckWorkshopUsed)
        =>
            truckWorkshop.AddTruckWorkshop(new TruckWorkshop
            {
                WorkOrderID = truckWorkshopUsed.WorkOrderID,
                workDescription = truckWorkshopUsed.workDescription,
                cost = truckWorkshopUsed.cost,
                Truck_ID = truckWorkshopUsed.Truck_ID
            });

        [HttpPut]
        public TruckWorkshop Put([FromBody] TruckWorkshop truckWorkshopUsed) =>
            truckWorkshop.UpdateTruckWorkshop(truckWorkshopUsed);

        [HttpDelete("{id}")]
        public void Delete(int id) => truckWorkshop.DeleteTruckWorkshop(id);
    }
}

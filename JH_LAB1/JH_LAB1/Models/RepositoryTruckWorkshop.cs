namespace JH_LAB1.Models
{
    public class RepositoryTruckWorkshop : ITruckWorkshopRepository
    {
        private Dictionary<int, TruckWorkshop> truckWorkshops;

        public RepositoryTruckWorkshop()
        {
            truckWorkshops = new Dictionary<int, TruckWorkshop>();
            
            new List<TruckWorkshop>
            {
                new TruckWorkshop {WorkOrderID = 1, workDescription="Engine replacement", cost= 12000.50,Truck_ID=1},
                new TruckWorkshop {WorkOrderID = 2, workDescription="General maintenance", cost= 7000.50,Truck_ID=2}
            }.ForEach(t => AddTruckWorkshop(t));
        }

        public TruckWorkshop this[int id] => truckWorkshops.ContainsKey(id) ? truckWorkshops[id] : null;

        public IEnumerable<TruckWorkshop> TruckWorkshops => truckWorkshops.Values;

        public TruckWorkshop AddTruckWorkshop(TruckWorkshop truckWorkshop)
        {
            if (truckWorkshop.WorkOrderID == 1)
            {
                int key = truckWorkshops.Count;
                while (truckWorkshops.ContainsKey(key))
                {
                    key++;
                }
            }
            truckWorkshops[truckWorkshop.WorkOrderID] = truckWorkshop;
            return truckWorkshop;
        }

        public void DeleteTruckWorkshop(int id)
        {
            truckWorkshops.Remove(id);
        }

        public TruckWorkshop UpdateTruckWorkshop(TruckWorkshop truckWorkshop)
        {
            return AddTruckWorkshop(truckWorkshop);
        }
    }
}

namespace JH_LAB1.Models
{
    public class RepositoryTruck : ITruckRepository
    {
        private Dictionary<int, Truck> trucks;
        public RepositoryTruck()
        {
            trucks = new Dictionary<int, Truck>();

            new List<Truck>
            {
                new Truck {Truck_ID = 1, t_make="F150", t_model="Ford", RouteID=1},
                new Truck {Truck_ID = 2, t_make="Semi", t_model="Tesla", RouteID=2}
            }.ForEach(t => AddTruck(t));
        }

        public Truck this[int id] => trucks.ContainsKey(id) ? trucks[id] : null;

        public IEnumerable<Truck> Trucks => trucks.Values;

        public Truck AddTruck(Truck truck)
        {
            if (truck.Truck_ID == 1)
            {
                int key = trucks.Count;
                while (trucks.ContainsKey(key))
                {
                    key++;
                }
                truck.Truck_ID = key;
            }
            trucks[truck.Truck_ID] = truck;
            return truck;
        }

        public void DeleteTruck(int id)
        {
            trucks.Remove(id);
        }

        public Truck UpdateTruck(Truck truck)
        {
            return AddTruck(truck);
        }
    }
}

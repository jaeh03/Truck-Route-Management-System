using System.Collections.Generic;

namespace JH_LAB1.Models
{
    public interface ITruckRepository
    {
        IEnumerable<Truck> Trucks { get; }
        Truck this[int id] { get; }
        Truck AddTruck(Truck truck);
        Truck UpdateTruck(Truck truck );
        void DeleteTruck(int id);
    }
}

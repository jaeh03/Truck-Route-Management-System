namespace JH_LAB1.Models
{
    public interface ITruckWorkshopRepository
    {
        IEnumerable<TruckWorkshop> TruckWorkshops { get; }
        TruckWorkshop this[int id] { get; }
        TruckWorkshop AddTruckWorkshop(TruckWorkshop truckWorkshop);
        TruckWorkshop UpdateTruckWorkshop(TruckWorkshop truckWorkshop);
        void DeleteTruckWorkshop(int id);
    }
}

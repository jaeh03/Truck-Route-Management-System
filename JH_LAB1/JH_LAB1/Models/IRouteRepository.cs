using System.Collections.Generic;

namespace JH_LAB1.Models
{
    public interface IRouteRepository
    {
        IEnumerable<Route> Routes { get; }
        Route this[int id] { get; }
        Route AddRoute (Route route);
        Route UpdateRoute (Route route);
        void DeleteRoute (int id);
    }
}

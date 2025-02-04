namespace JH_LAB1.Models
{
    public class RepositoryRoute : IRouteRepository
    {
        private Dictionary<int, Route> routes;

        public RepositoryRoute()
        {
            routes = new Dictionary<int, Route>();

            new List<Route>
            {
                new Route {RouteID = 1, route_name="Expressway 401", r_length=100, r_pay_per_km=5.5},
                new Route {RouteID = 2, route_name="Highway 401", r_length=200, r_pay_per_km=6.75}
                }.ForEach(r => AddRoute(r));
            
        }

        public Route this[int id] => routes.ContainsKey(id) ? routes[id] : null;

        public IEnumerable<Route> Routes => routes.Values;

        public Route AddRoute(Route route)
        {
            if (route.RouteID == 1)
            {
                int key = routes.Count;
                while (routes.ContainsKey(key))
                {
                    key++;
                }
                route.RouteID = key;
            }
            routes[route.RouteID] = route;
            return route;
        }

        public void DeleteRoute(int id)
        {
            routes.Remove(id);
        }

        public Route UpdateRoute(Route route)
        {
            return AddRoute(route);
        }
    }
}

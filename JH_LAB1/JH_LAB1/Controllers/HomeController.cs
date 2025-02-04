using JH_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using Route = JH_LAB1.Models.Route;

namespace JH_LAB1.Controllers
{
    public class HomeController : Controller
    {
        private IRouteRepository routeRepository;
        private ITruckRepository truckRepository;
        private ITruckWorkshopRepository truckWorkshopRepository;
        private IUserRepository userRepository;

        public HomeController(IRouteRepository routeRepository, ITruckRepository truckRepository, ITruckWorkshopRepository truckWorkshopRepository, IUserRepository userRepository)
        {
            this.routeRepository = routeRepository;
            this.truckRepository = truckRepository;
            this.truckWorkshopRepository = truckWorkshopRepository;
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View("Index"); 
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            var getUsers = userRepository.Users.ToList();

            foreach (User u in getUsers)
            {
                if (user.Email == u.Email && user.Password == u.Password)
                {
                    return View("Route");
                }
            }
            ViewBag.incorrectLogin = "Incorrect email or password.";
            return RedirectToAction("Index");
        }

        public IActionResult RegisterUser()
        {
            return View(userRepository.Users); 
        }
        [HttpPost]
        public IActionResult RegisterUser(User user)
        {
            if (ModelState.IsValid)
            {
                var getUsers = userRepository.Users.ToList();

                foreach (User u in getUsers)
                {
                    if (u.Email == user.Email)
                    {
                        ViewBag.existingEmail = "A user with this email address already exists, do you want to login?";
                        return View("RegisterUser");
                    }
                }
                userRepository.AddUser(user);
                return View("Index");
            }
            return RedirectToAction("RegisterUser");
        }
        public IActionResult Route()
        {
            return View(routeRepository.Routes);
        }

        [HttpPost]
        public IActionResult Route(Route route)
        {
            routeRepository.AddRoute(route);
            return RedirectToAction("Route");
        }
        public IActionResult Truck()
        {
            return View(truckRepository.Trucks); 
        }
        [HttpPost]
        public IActionResult Truck(Truck truck)
        {
            truckRepository.AddTruck(truck);
            return RedirectToAction("Truck");
        }
        public IActionResult TruckWorkshop()
        {
            return View(truckWorkshopRepository.TruckWorkshops); 
        }

        [HttpPost]
        public IActionResult TruckWorkshop(TruckWorkshop truckWorkshop)
        {
            truckWorkshopRepository.AddTruckWorkshop(truckWorkshop);
            return RedirectToAction("Truckworkshop");
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
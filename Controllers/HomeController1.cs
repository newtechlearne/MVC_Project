using Microsoft.AspNetCore.Mvc;
using Project.Models; // Assuming the Model class is in this namespace

namespace Project.Controllers
{
    public class HomeController : Controller // Renamed to HomeController
    {
        // GET: Home
        public ActionResult Index()
        {
            var items = new List<Model>
            {
                new Model { Id = 1, Name = "Item 1", Price = 10.99M },
                new Model { Id = 2, Name = "Item 2", Price = 20.99M },
                new Model { Id = 3, Name = "Item 3", Price = 30.99M }
            };

            return View(items); // Passes the items to the view
        }
    }
}



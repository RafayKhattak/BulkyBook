// Importing necessary namespaces
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Defining a controller for handling home-related actions
namespace BulkyBookWeb.Controllers
{
    public class HomeController : Controller
    {
        // Private logger field for logging
        private readonly ILogger<HomeController> _logger;

        // Constructor to initialize the controller with a logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action method for displaying the home page
        public IActionResult Index()
        {
            // Returning the default view for the home page
            return View();
        }

       
        // Action method for handling errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Returning the error view with information about the error
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

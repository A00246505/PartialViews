using Microsoft.AspNetCore.Mvc;
using PartialViews.Models;
using System.Diagnostics;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Films = new List<Films>()
            {
                new Films{Title = "Red Notice" , Duration = "1h 55m" , Description = "In the world of international crime, an Interpol agent attempts to hunt down and capture the world's most wanted art thief"},
                new Films{Title = "Free Guy" , Duration = "1h 55m" , Description = "When a bank teller discovers he's actually a background player in an open-world video game, he decides to become the hero of his own story"},
                new Films{Title = "The Amazing Spider-Man" , Duration = "2h 16m" , Description = "Peter Parker, an outcast high school student, gets bitten by a radioactive spider and attains superpowers. Soon, he is forced to use his abilities to fight a monstrous foe."}

            };

            var FilmsViewModel = new FilmsViewModel
            {
                films = Films
        };

            return View(FilmsViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ShowPartialView()
        {
            return PartialView("Films");
        }
    }
}
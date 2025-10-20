using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using System.Diagnostics;

namespace StudentPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<Student> students =
        [
            new() { Id = 1, Name = "Alice Johnson", Email = "alice@example.com", Course = "Computer Science" },
            new() { Id = 2, Name = "Bob Smith", Email = "bob@example.com", Course = "Mathematics" },
            new() { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com", Course = "Physics" },
            new() { Id = 4, Name = "Diana Prince", Email = "diana@example.com", Course = "Chemistry" }
        ];


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);

            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return RedirectToAction("Index");
            }

            return View();
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
    }
}

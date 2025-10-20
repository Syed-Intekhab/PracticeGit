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

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int Id)
        {
            Student? foundStudent = null;

            // Add views later for bad request and for not found!
            if (Id <= 0 || !students.Any(s => s.Id == Id))
            {
                return RedirectToAction("Index");
            }
            else if (string.IsNullOrWhiteSpace(Id.ToString()))
            {
                return RedirectToAction("Index");
            }

            foreach(Student student in students)
            {
                if(student.Id == Id)
                {
                    foundStudent = student;
                }
            }

            return View(foundStudent);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            foreach(Student item in students)
            {
                if(student.Id == item.Id)
                {
                    item.Name = student.Name;
                    item.Email = student.Email;
                    item.Course = student.Course;
                }
            }

            return RedirectToAction("Index");
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

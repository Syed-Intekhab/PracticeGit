using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using System.Diagnostics;
using System.Transactions;

namespace StudentPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<StudentViewModel> students =
        [
            new() {
                StudentInfo = new()
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john@example.com"
                },
                Courses = ["Math", "Science", "History", "Literature", "Art"],
                IsTopStudent = false 
            },
            new()
            {
                StudentInfo = new()
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Email = "jane@example.com"
                },
                Courses = ["Math", "Science", "History", "Literature", "Art"],
                IsTopStudent = true
            },
            new()
            {
                StudentInfo = new()
                {
                    Id = 3,
                    Name = "Alice Johnson",
                    Email = "alice@example.com"
                },
                Courses = ["Math", "Science", "History", "Literature", "Art"],
                IsTopStudent = false 
            }
        ];

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // This comment is in filter-student branch
            ViewBag.Message = "Making a conflict!";

            // Test merge conflict
            ViewBag.CreateMergeConflict = "This line is coming from conflict-test branch!";

            return View(students.OrderBy(s => s.StudentInfo.Id));
        }

        public IActionResult Edit(int Id)
        {
            StudentViewModel foundStudent;

            // Add views later for bad request and for not found!
            if (Id <= 0)
            {
                return RedirectToAction("Index");
            }
            else if (string.IsNullOrWhiteSpace(Id.ToString()))
            {
                return RedirectToAction("Index");
            }

            foreach(var student in students)
            {
                if(student.StudentInfo.Id == Id)
                {
                    foundStudent = student;

                    return View(foundStudent);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(StudentViewModel student)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            foreach(var item in students)
            {
                if(student.StudentInfo.Id == item.StudentInfo.Id)
                {
                    item.StudentInfo.Name = student.StudentInfo.Name;
                    item.StudentInfo.Email = student.StudentInfo.Email;
                    item.Courses = student.Courses;
                    item.IsTopStudent = student.IsTopStudent;
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            var model = new StudentViewModel 
            { 
                StudentInfo = new Student(),
                Courses = new List<string>(),
                IsTopStudent = false
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel student)
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

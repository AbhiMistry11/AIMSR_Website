using AIMSRCollegeWebsite.Data;
using AIMSRCollegeWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace AIMSRCollegeWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Admission()
        {
            return View();
        }

        public IActionResult Placement()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var query = new ContactQuery
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    Subject = model.Subject,
                    Message = model.Message,
                    SubmissionDate = DateTime.Now
                };
                _context.ContactQueries.Add(query);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Your message has been submitted successfully!";
                return RedirectToAction(nameof(Contact));
            }
            return View(model);
        }

        // Add these new action methods for the other buttons
        public IActionResult ExploreUndergraduate()
        {
            return RedirectToAction("Admission"); // Redirect to admission page with focus on undergraduate
        }

        public IActionResult ExplorePostgraduate()
        {
            return RedirectToAction("Admission"); // Redirect to admission page with focus on postgraduate
        }

        public IActionResult ExploreResearch()
        {
            return RedirectToAction("About"); // Redirect to about page with focus on research
        }

        public IActionResult NewsDetail(int id)
        {
            // Logic to fetch news by id
            ViewBag.NewsId = id;
            return View();
        }

        public IActionResult AllEvents()
        {
            // Logic to fetch all events
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
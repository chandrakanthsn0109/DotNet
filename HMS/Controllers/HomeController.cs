using System.Diagnostics;
using HMS;
using HMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace HMS_Entity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HMSDbContext _context;

        public HomeController(ILogger<HomeController> logger, HMSDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowData()
        {
            return RedirectToAction("Index", "Hospitals");
        }

        public IActionResult PatView()
        {
            ViewData["PatientInfo"] = TempData["Patient"];
            return View();
        }

        public IActionResult CreateDoctor(string name, string qualification, string specialty)
        {
            TempData["Name"] = name;
            TempData["Qualification"] = qualification;
            TempData["Specialty"] = specialty;

            return RedirectToAction("Create", "Hospitals");
        }

        public IActionResult ShowMedical(string pName, string dName)
        {
            TempData["PatientName"] = pName;
            TempData["DiseaseName"] = dName;

            var hospitalDoctorQuery = from h in _context.Hospital
                                      join d in _context.Doctor on h.HosId equals d.HosId
                                      where d.Specality == dName  
                                      select new
                                      {
                                          HospitalName = h.HosName,
                                          DoctorName = d.DocName 
                                      };

            var results = hospitalDoctorQuery.ToList();
            var hospitalName = string.Empty;
            var doctorName = string.Empty;

            if (results.Any())
            {
                var firstResult = results.First();
                hospitalName = firstResult.HospitalName;
                doctorName = firstResult.DoctorName;

                TempData["PatientMessage"] = $"Patient {pName} must visit {hospitalName} to consult Dr.{doctorName} for {dName} specialty.";
            }
            else
            {
                TempData["PatientMessage"] = $"No hospital or doctor found for the {dName} specialty.";
            }

            return RedirectToAction("PatView", "Home");
        }

        public IActionResult Doctors()
        {
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

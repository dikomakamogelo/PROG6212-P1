using CMCS.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMCS.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var claims = new List<ClaimSummary> {
                new(){ Month="Aug 2025", Status="Draft", TotalHours=10, TotalAmount=4500 },
                new(){ Month="Jul 2025", Status="PC Approved", TotalHours=20, TotalAmount=9000 },
                new(){ Month="Jun 2025", Status="AM Approved", TotalHours=15, TotalAmount=6750 }
            };
            return View(claims);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var entries = new List<ClaimEntry> {
                new(){ WorkDate=new DateOnly(2025,8,5), Module="INF101", TaskType="Teaching", Hours=3, Notes="Lecture 1" }
            };
            return View(entries);
        }

        [HttpPost]
        public IActionResult Create(List<ClaimEntry> entries)
        {
            TempData["Msg"] = "Claim submitted (prototype).";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Queue()
        {
            var queue = new List<ClaimSummary> {
                new(){ Month="Aug 2025", Status="Submitted", TotalHours=12, TotalAmount=5400 },
                new(){ Month="Jul 2025", Status="Submitted", TotalHours=20, TotalAmount=9000 }
            };
            return View(queue);
        }
    }
}
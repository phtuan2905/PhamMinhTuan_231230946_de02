using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhamMinhTuan_231230946_de02.Models;

namespace PhamMinhTuan_231230946_de02.Controllers
{
    public class PmtHomeController : Controller
    {
        private readonly ILogger<PmtHomeController> _logger;

        public PmtHomeController(ILogger<PmtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PmtIndex()
        {
            return View("PmtIndex");
        }

        public IActionResult PmtPrivacy()
        {
            return View("PmtPrivacy");
        }

        public IActionResult PmtAbout()
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

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Rule.UI.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Mental()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendPhoneNumber(string phoneNumber)
        {
            TempData["Message"] = "��� ����� ������ ��������, � ���� ����� ��'�������";
            return RedirectToAction("Index");
        }
    }
}

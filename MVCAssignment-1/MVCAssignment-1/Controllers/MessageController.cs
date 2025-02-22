using Microsoft.AspNetCore.Mvc;
using MVCAssignment_1.Models;

namespace MVCAssignment_1.Controllers
{
    public class MessageController : Controller
    {
        //[HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        public IActionResult Display(string username)
        {
            ViewBag.username = username;
            return View();
        }
    }
}

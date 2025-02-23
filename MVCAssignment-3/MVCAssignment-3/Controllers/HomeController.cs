using Microsoft.AspNetCore.Mvc;
using MVCAssignment_3.Models;

namespace MVCAssignment_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHallDAO dal;
        public HomeController(IHallDAO dal)
        {
            this.dal = dal;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(int price)
        {
            return View(dal.GetHall(price));
        }
    }
}

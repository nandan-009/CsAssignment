using Microsoft.AspNetCore.Mvc;
using MVCAssignment_2.Models;

namespace MVCAssignment_2.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }
         
        public IActionResult Calculate(Rent record)
        {
            ViewBag.Name = record.Name;
            ViewBag.HallOwner= record.HallOwner;
            ViewBag.CostPerDay= record.CostPerDay;
            ViewBag.StartDate = record.StartDate.ToShortDateString();
            ViewBag.EndDate = record.EndDate.ToShortDateString();
            
            TimeSpan t= record.EndDate - record.StartDate;
            int a = t.Days;
            ViewBag.TotalCost = a*record.CostPerDay;


            return View();
        }
    }
}

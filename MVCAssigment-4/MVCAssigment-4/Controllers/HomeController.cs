using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCAssigment_4.Models;

namespace MVCAssigment_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieDAO dal;
        public HomeController(IMovieDAO dal)
        {
            this.dal = dal;
        }

       

        public IActionResult Index()
        {
            MovieVM movieVM = new MovieVM();
            movieVM.Movies = dal.GetAllMovies();
          
            return View(movieVM);
        }

        public IActionResult Create(Movie movie)
        {
            int i = dal.GetAllMovies().Count() + 1;
            dal.AddMovie(movie,i);
            return RedirectToAction("Index");
        }
    }
}

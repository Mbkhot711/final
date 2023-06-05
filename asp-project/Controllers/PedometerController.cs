using asp_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_project.Controllers
{
    public class PedometerController : Controller
    {
        private StepsContext _scontext;
        public PedometerController(StepsContext scontext)
        {
            _scontext = scontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StepsToCalories(Steps TotalCaloriesBurned)
        {
            TotalCaloriesBurned.StepsDate = DateTime.Now;

            _scontext.Steps.Add(TotalCaloriesBurned);
            _scontext.SaveChanges();

            return View(TotalCaloriesBurned);
        }
    }
}

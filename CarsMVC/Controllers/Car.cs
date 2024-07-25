using CarsMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarsMVC.Controllers
{
    public class Car : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Model (string year , string name)
        {
            CarModel model = new CarModel()
            {
                name = name ?? "error",
                year = year ?? "error"
            };
            return View(model);
        }
    }
}

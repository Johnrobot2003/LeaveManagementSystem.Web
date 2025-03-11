using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class ChickenController : Controller
    {
        public IActionResult Index()
        {
            var data = new ChickenModel
            {
                Breed = "Rooster"
            };
            return View(data);
        }
    }
}

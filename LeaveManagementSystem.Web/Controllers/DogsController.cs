using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            var data = new DogsViewModel
            {
                Name = "Marsha",
                Age = 4
            };
            return View(data);
        }
    }
}

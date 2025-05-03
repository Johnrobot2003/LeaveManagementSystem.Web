using LeaveManagementSystem.Web.Models.Employees;
using LeaveManagementSystem.Web.Services.EmpoyeeList;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class EmployeeListController(IEmployeeListServices _employeeListService) : Controller
    {
        public async Task<IActionResult>Index()
        {
          var model = await _employeeListService.ListOfEmployees();
            return View(model);
        }

        public async Task<IActionResult> ResetPassword(string? userId)
        {
            var model = await _employeeListService.ResetPassword(userId);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPassword)
        {
            throw new NotImplementedException();
        }

    }
}

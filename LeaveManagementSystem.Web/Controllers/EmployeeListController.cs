using LeaveManagementSystem.Web.Models.Employees;
using LeaveManagementSystem.Web.Models.LeaveTypes;
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
            if (userId == null)
            {
                return NotFound();
            }
            var model = await _employeeListService.Get<ResetPasswordVM>(userId);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPasswordConfirmed(string? userId)
        {
           await _employeeListService.ResetPasswordToDefault(userId);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string? userid)
        {
            if (userid == null)
            {
                return NotFound();
            }

            var employees = await _employeeListService.Get<AllEmployeesVM>(userid);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string? userid)
        {
            await _employeeListService.Remove(userid);
            return RedirectToAction(nameof(Index));
        }


    }
}

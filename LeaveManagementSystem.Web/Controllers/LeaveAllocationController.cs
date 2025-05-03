using LeaveManagementSystem.Web.Models.LeaveAllocations;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using LeaveManagementSystem.Web.Services.LeaveAllocations;
using LeaveManagementSystem.Web.Services.LeaveTypes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Web.Controllers
{
    [Authorize]
    public class LeaveAllocationController (ILeaveAllocationService _leaveAllocationSercvice, ILeaveTypeService _leaveTypeService) : Controller
    {
       
        public async Task<IActionResult> Details(string? userid)
        {
          
           var employeVM = await  _leaveAllocationSercvice.GetEmployeeAllocation(userid);
            return View(employeVM);
        }
        [Authorize(Roles = Roles.Adminitrator)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(string? id)
        {

             await _leaveAllocationSercvice.AllocateLeave(id);
            return RedirectToAction(nameof(Details), new {userid = id});
        }

        [Authorize(Roles = Roles.Adminitrator)]
        public async Task<IActionResult> Index()
        {

            var employees = await _leaveAllocationSercvice.GetEmployees();
            return View(employees);
        }

        [Authorize(Roles = Roles.Adminitrator)]
        public async Task<IActionResult> EditAllocation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var allocation = await _leaveAllocationSercvice.GetEmployeeAllocations(id.Value);

            if (allocation == null)
            {
                return NotFound();
            }
            return View(allocation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllocation(LeaveAllocationEditVM allocationEditVm)
        {
            if (allocationEditVm.Days >105 || allocationEditVm.Days < 1)
            {
                ModelState.AddModelError(nameof(allocationEditVm.Days), "Invalid input");
            }
            else
            {
                await _leaveAllocationSercvice.EditAllocation(allocationEditVm);
                return RedirectToAction(nameof(Details), new { userId = allocationEditVm.Employee.Id });
            }
            return View(allocationEditVm);
        }
    }
}

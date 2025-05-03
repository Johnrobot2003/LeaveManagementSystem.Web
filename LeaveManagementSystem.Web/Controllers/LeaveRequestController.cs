using LeaveManagementSystem.Web.Models.LeaveRequest;
using LeaveManagementSystem.Web.Services.LeaveRequests;
using LeaveManagementSystem.Web.Services.LeaveTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagementSystem.Web.Controllers
{
    [Authorize]
    public class LeaveRequestController (ILeaveTypeService _leaveTypesService, ILeaveRequestService _leaveRequestService): Controller
    {

        //view
        public async Task<IActionResult> Index()
        {
            var model = await _leaveRequestService.GetEmployeeLeaveRequest();
            return View(model);
        }

        //create requests
        public async Task<IActionResult> Create(int? leaveTypeId)
        {
           
            var leaveTypes = await _leaveTypesService.GetAllLeaveTypesAsync();
            var leaveTypesList = new SelectList(leaveTypes, "Id", "Name",leaveTypeId);
            var model = new LeaveRequestCreateVM
            {
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                LeaveTypes = leaveTypesList,
            };
            return View(model);
        }

        //create requests
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {

            if (await _leaveRequestService.RequestDatesExceedAllocation(model))
            {
                ModelState.AddModelError(nameof(model.EndDate), "Number of days is invalids.");
            }
            if (ModelState.IsValid)
            {
                await _leaveRequestService.CreateLeaveRequest(model);
                return RedirectToAction(nameof(Index));
            }
            var leaveTypes = await _leaveTypesService.GetAllLeaveTypesAsync();
            var leaveTypesList = new SelectList(leaveTypes, "Id", "Name");
            model.LeaveTypes = leaveTypesList;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancel(int id)
        {
             await _leaveRequestService.CancelLeaveRequst(id);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = "AdminSupervisorOnly")]
        public async Task<IActionResult> ListRequest()
        {
            var model  = await _leaveRequestService.AdminGetAllLeaveRequest();
            return View(model);
        }
        public async Task<IActionResult> Review(int id)
        {
           var model = await _leaveRequestService.GetLeaveRequestForReview(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Review(int id , bool approved)
        {
            await _leaveRequestService.ReviewLeaveRequest(id, approved);
            return RedirectToAction(nameof(ListRequest));
        }
    }
}

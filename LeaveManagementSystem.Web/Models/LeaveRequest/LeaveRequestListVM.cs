using LeaveManagementSystem.Web.Models.LeaveAllocations;
using LeaveManagementSystem.Web.Services.LeaveRequests;

namespace LeaveManagementSystem.Web.Models.LeaveRequest
{
    public class LeaveRequestReadOnlyVM
    {
        public int Id { get; set; }
        public EmployeeListVM Employee { get; set; } = new EmployeeListVM();

        [Display(Name = "Start Date")]
        public DateOnly StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateOnly EndDate { get; set; }
        [Display(Name = "Total Days")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Leave Type")]
        public string LeaveType { get; set; } = string.Empty;
        public LeaveRequestStatusEnum LeaveRequestStatus { get; set; }
        
    }
}
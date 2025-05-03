using LeaveManagementSystem.Web.Models.LeaveAllocations;

namespace LeaveManagementSystem.Web.Models.LeaveRequest
{
    public class LeaveRequestReviewVM: LeaveRequestReadOnlyVM
    {
        public EmployeeListVM Employee { get; set; } = new EmployeeListVM();
        [Display(Name = "Comments")]
        public string? RequestComments { get; set; }
    }
}
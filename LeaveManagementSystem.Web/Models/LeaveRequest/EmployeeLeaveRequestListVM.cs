using LeaveManagementSystem.Web.Models.Employees;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace LeaveManagementSystem.Web.Models.LeaveRequest
{
    public class EmployeeLeaveRequestListVM
    {
        [Display(Name = "Total Requests ")]
        public int  TotalRequests { get; set; }
        [Display(Name = "Approved Requests")]
        public int ApprovedRequests{ get; set; }
        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected Requests")]
        public int DeclinedRequests   { get; set; }
        public List<LeaveRequestReadOnlyVM> LeaveRequests { get; set; } = []; // or use this new List<LeaveRequestReadOnlyVM>();
        public List<AllEmployeesVM> Employees { get; set; } = [];
    }
}
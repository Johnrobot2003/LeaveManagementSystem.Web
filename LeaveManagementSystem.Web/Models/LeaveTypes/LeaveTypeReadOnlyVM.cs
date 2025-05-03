using LeaveManagementSystem.Web.Models.LeaveAllocations;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM:BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;

        [Display (Name = "Number of Days")]
        public int NumberOfDays { get; set; }

        public List<LeaveAllocationVM> LeaveAllocations { get; set; }

    }
}

namespace LeaveManagementSystem.Web.Models.LeaveAllocations
{
    public class EmployeeAllocationVM:EmployeeListVM
    {
       

        [Display(Name = "Date of Birth")]
        public DateOnly DateOfBirth { get; set; }

        public string Email { get; set; } = string.Empty;
        public bool IsCompletedAllocation { get; set; }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    
      
    }
}


using LeaveManagementSystem.Web.Models.LeaveAllocations;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public interface ILeaveAllocationService
    {
        Task AllocateLeave(string employeeId);
    
        Task<EmployeeAllocationVM> GetEmployeeAllocation(string? userid);
        Task<List<EmployeeListVM>> GetEmployees();
        Task<LeaveAllocationEditVM> GetEmployeeAllocations(int allocationid);
        Task EditAllocation(LeaveAllocationEditVM allocationEditVm);
    }
}

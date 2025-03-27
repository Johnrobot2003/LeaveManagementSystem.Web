using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services.LeaveTypes
{
    public interface ILeaveTypeService
    {
        Task Create(LeaveTypeCreateVM leaveType);
        Task Edit(LeaveTypeEditVM leaveType);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypesAsync();
        bool LeaveTypeExists(int id);
        Task<bool> NameExistsInCreateAsync(LeaveTypeCreateVM leave);
        Task<bool> NameExistsInCreateForEdit(LeaveTypeEditVM leave);
        Task Remove(int id);
    }
}
using LeaveManagementSystem.Web.Models.LeaveRequest;

namespace LeaveManagementSystem.Web.Services.LeaveRequests
{
    public interface ILeaveRequestService
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<List<LeaveRequestReadOnlyVM>> GetEmployeeLeaveRequest();
        Task<EmployeeLeaveRequestListVM> AdminGetAllLeaveRequest();
        Task CancelLeaveRequst(int leaveRequestId);

        Task ReviewLeaveRequest(int id, bool approved);

        Task <bool> RequestDatesExceedAllocation(LeaveRequestCreateVM model);
        Task <LeaveRequestReviewVM> GetLeaveRequestForReview(int id);
    }
}
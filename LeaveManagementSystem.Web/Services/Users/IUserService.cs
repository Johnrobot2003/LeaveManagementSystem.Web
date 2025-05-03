namespace LeaveManagementSystem.Web.Services.Users
{
    public interface IUserService
    {
        Task<ApplicationUser> GetLoggedInUser();
        Task<ApplicationUser> GetUserById(string userid);
        Task<List<ApplicationUser>>GetEmployees();
    }
}
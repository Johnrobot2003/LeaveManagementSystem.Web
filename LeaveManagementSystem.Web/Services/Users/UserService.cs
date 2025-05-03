
namespace LeaveManagementSystem.Web.Services.Users
{
    public class UserService(UserManager<ApplicationUser> _userManager, IHttpContextAccessor _httpContextAccessor) : IUserService
    {
        public async Task<List<ApplicationUser>> GetEmployees()
        {
            var users = await _userManager.GetUsersInRoleAsync(Roles.Employee);
            return users.ToList();
        }

        public async Task<ApplicationUser> GetLoggedInUser()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);

            return user;
        }
        public async Task<ApplicationUser> GetUserById(string userid)
        {
            var user = await _userManager.FindByIdAsync(userid);
            return user;
        }
    }
}

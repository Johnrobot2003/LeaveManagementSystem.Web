using AutoMapper;
using LeaveManagementSystem.Web.Models.Employees;
using LeaveManagementSystem.Web.Models.LeaveAllocations;

namespace LeaveManagementSystem.Web.Services.EmpoyeeList
{
    public class EmployeeListService(ApplicationDbContext _context, IHttpContextAccessor _httpContext, UserManager<ApplicationUser> _userManager, IMapper _mapper) : IEmployeeListServices
    {
        /*public async Task<List<EmployeeListVM>> ListOfEmployees()
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.Employee);
            var employeeList = _mapper.Map<List<ApplicationUser>,List<EmployeeListVM>>(employees.ToList());

            return employeeList;
        }*/
        /* public async Task<List<EmployeeListVM>> ListOfEmployees()
         {
             var employees = await _userManager.GetUsersInRoleAsync(Roles.Employee);
             var employeeList = _mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(employees.ToList());

             return employeeList;
         }*/
        public async Task<List<AllEmployeesVM>> ListOfEmployees()
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.Employee);
            var employeeList = _mapper.Map<List<ApplicationUser>, List<AllEmployeesVM>>(employees.ToList());

            return employeeList;
        }
        public async Task<ResetPasswordVM> ResetPassword(string? userId)
        {
            var user = string.IsNullOrEmpty(userId) ? await _userManager.GetUserAsync(_httpContext.HttpContext?.User)
                : await _userManager.FindByIdAsync(userId);

            var resetPasswordVm = new ResetPasswordVM
            {
               Password = string.Empty,
                ConfirmPassword = string.Empty,
                Id = user.Id,
                Employee = new AllEmployeesVM
                {
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Id = user.Id
                }
            };
            return resetPasswordVm;
        }
    }
}


using AutoMapper;
using LeaveManagementSystem.Web.Models.Employees;
using LeaveManagementSystem.Web.Models.LeaveAllocations;
using Microsoft.EntityFrameworkCore;

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

        public async Task Remove(string? userId)
        {
            var users =await _userManager.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (users != null)
            {
                _context.Remove(users);
                await _context.SaveChangesAsync();
            }
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
        public async Task<T> Get<T>(string userid) where T : class
        {
            var data = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == userid);
            if (data == null)
            {
                return null;
            }
            var viewData = _mapper.Map<T>(data);
            return viewData;
        }

    }
}


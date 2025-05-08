using AutoMapper;
using LeaveManagementSystem.Web.Models.Employees;
using LeaveManagementSystem.Web.Models.LeaveAllocations;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
        public async Task<bool> ResetPasswordToDefault(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var isAdmin = await _userManager.GetUsersInRoleAsync(Roles.Adminitrator);
            if (user == null)
            {
                return false;
            }
           
            var defaultPass = isAdmin.IsReadOnly ? DefaultPassword.AdminPasswordDefault : DefaultPassword.PasswordDefault;
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, defaultPass);
            

            

            return result.Succeeded;
        }

       
    }
}


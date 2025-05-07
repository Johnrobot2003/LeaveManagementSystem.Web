using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagementSystem.Web.Models.Employees
{
    public class CangeUserRoleVM : AllEmployeesVM
    {
        public string? CurrentRole { get; set; }
        public string? NewRole { get; set; }
        public SelectList? Roles { get; set; }
    }
}

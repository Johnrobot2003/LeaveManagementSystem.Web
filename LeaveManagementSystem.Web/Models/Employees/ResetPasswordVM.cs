

namespace LeaveManagementSystem.Web.Models.Employees
{
    public class ResetPasswordVM
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string  ConfirmPassword{ get; set; }
        public AllEmployeesVM Employee { get; set; } = new AllEmployeesVM();

    }
}
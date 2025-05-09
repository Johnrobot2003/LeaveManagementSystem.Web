﻿using LeaveManagementSystem.Web.Models.Employees;
using LeaveManagementSystem.Web.Models.LeaveAllocations;

namespace LeaveManagementSystem.Web.Services.EmpoyeeList
{
    public interface IEmployeeListServices
    {
        Task<List<AllEmployeesVM>> ListOfEmployees();
        Task Remove(string? userId);
        Task<T> Get<T>(string userid) where T : class;
        Task<bool> ResetPasswordToDefault(string? userId);
    }
}
